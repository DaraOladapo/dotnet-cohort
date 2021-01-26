using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentsAndCourses.Library.Data;
using StudentsAndCourses.Library.Interfaces;
using StudentsAndCourses.Library.Models.Binding;
using StudentsAndCourses.Library.Models.Entity;
using StudentsAndCourses.Library.Models.ViewModels;
using StudentsAndCourses.Library.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentsAndCourses.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private ILogger<StudentController> _logger;
        private ApplicationDbContext dbContext;
        private IRepositoryWrapper repository;
        public StudentController(ILogger<StudentController> logger, ApplicationDbContext applicationDb, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            dbContext = applicationDb;
            repository = repositoryWrapper;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudentViewModel> Get()
        {
            var allStudents = dbContext.Students.ToList();
            var allCourses = dbContext.Courses.ToList();
            //var allRegistrations = new List<Registration>();
            var allRegistrations = dbContext.Registrations.ToList();
            List<StudentViewModel> studentViewModels = new List<StudentViewModel>();
            foreach (var student in allStudents)
            {
                studentViewModels.Add(new StudentViewModel() { Student = student });
            }
            foreach (var studentViewModel in studentViewModels)
            {
                studentViewModel.Registrations = allRegistrations.Where(s => s.Student.Id == studentViewModel.Student.Id).Select(c => c.Course).ToList();
            }
            _logger.LogInformation($"{studentViewModels.Count} students gotten.");
            return studentViewModels;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult<StudentViewModel> Get(int id)
        {
            var studentFound = dbContext.Students.FirstOrDefault(s => s.Id == id);
            if (studentFound == null)
            {
                _logger.LogWarning($"student with ID {id} not found.");
                return NotFound($"student with ID {id} not found.");
            }
            _logger.LogInformation($"student with id {id} gotten");
            var studentCourses = dbContext.Registrations.Where(s => s.Student.Id == id).Select(c => c.Course).ToList();
            var studentFoundViewModel = new StudentViewModel { Student = studentFound, Registrations = studentCourses };
            return studentFoundViewModel;
        }
        [HttpGet("{id}/courses")]
        public ActionResult<List<Course>> GetCoursesByStudent(int id)
        {
            var student = repository.Students.FindByCondition(s => s.Id == id).FirstOrDefault();
            var studentViewModel = new StudentViewModel() { Student = student };
            var allRegistrations = repository.Registrations.FindAll().ToList();
            var allCourses = repository.Courses.FindAll();
            var studentMatchingCourseQuery = allRegistrations
                .Join(allCourses, r => r.CourseId, c => c.Id, (allRegistrations, allCourses) =>  
                new Course { Id = allCourses.Id, Code = allCourses.Code, Title = allCourses.Title } );
            var studentCourses = studentMatchingCourseQuery.ToList();
            studentViewModel.Registrations = studentCourses;
            return studentViewModel.Registrations;
        }
        // POST api/<StudentController>
        [HttpPost]
        public ActionResult<StudentViewModel> Post([FromBody] AddStudent student)
        {
            var existingStudent = dbContext.Students.FirstOrDefault(s => s.EmailAddress == student.EmailAddress);
            if (existingStudent != null)
            {
                _logger.LogError("Data conflict");
                return Conflict("Student already exists.");
            }
            if (string.IsNullOrEmpty(student.Name))
                return BadRequest("student name is empty");
            if (!student.EmailAddress.IsValidEmail())
                return BadRequest("Invalid Email address");
            var addedStudent = dbContext.Students.Add(new Student { Name = student.Name, EmailAddress = student.EmailAddress }).Entity;
            dbContext.SaveChanges();
            return new StudentViewModel { Student = addedStudent, Registrations = new List<Course>() };
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult<StudentViewModel> Put(int id, [FromBody] UpdateStudent student)
        {
            var studentToUpdate = dbContext.Students.FirstOrDefault(s => s.Id == id);
            if (studentToUpdate == null)
            {
                _logger.LogWarning($"student with ID {id} not found.");
                return NotFound($"student with ID {id} not found.");
            }
            if (string.IsNullOrEmpty(student.Name))
                return BadRequest("student name is empty");
            if (!student.EmailAddress.IsValidEmail())
                return BadRequest("Invalid Email address");
            studentToUpdate.Name = student.Name;
            studentToUpdate.EmailAddress = student.EmailAddress;
            dbContext.SaveChanges();
            var studentCourses = dbContext.Registrations.Where(s => s.Student.Id == id).Select(c => c.Course).ToList();
            var studentFoundViewModel = new StudentViewModel { Student = studentToUpdate, Registrations = studentCourses };
            return studentFoundViewModel;
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var studentToDelete = dbContext.Students.FirstOrDefault(s => s.Id == id);
            if (studentToDelete == null)
            {
                _logger.LogWarning($"student with ID {id} not found.");
                return NotFound($"student with ID {id} not found.");
            }
            var coursesToDelete = dbContext.Registrations.Where(c => c.Student.Id == id);
            foreach (var course in coursesToDelete)
            {
                dbContext.Registrations.Remove(course);
                dbContext.SaveChanges();
            }
            _logger.LogCritical($"deleting course registration for {studentToDelete.Name} completed");
            dbContext.Remove(studentToDelete);
            dbContext.SaveChanges();
            _logger.LogCritical($"deleting {studentToDelete.Name} completed");
            return NoContent();
        }

        [HttpPost("{id}/addcourse")]
        public ActionResult<StudentViewModel> AddCourse(int id, [FromQuery] int courseID)
        {
            var student = dbContext.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound("Student not found");
            var course = dbContext.Courses.FirstOrDefault(c => c.Id == courseID);
            if (course == null)
                return NotFound("course not found");
            var addRegistration = new AddRegistration { Course = course, Student = student };
            var registrationToAdd = new Registration { Course = addRegistration.Course, Student = addRegistration.Student };
            var addedRegistration = dbContext.Registrations.Add(registrationToAdd).Entity;
            dbContext.SaveChanges();
            var studentCourses = dbContext.Registrations.Where(s => s.Student.Id == id).Select(c => c.Course).ToList();
            var studentFoundViewModel = new StudentViewModel { Student = student, Registrations = studentCourses };
            return studentFoundViewModel;
        }
        [HttpDelete("{id}/addcourse")]
        public ActionResult<StudentViewModel> DeleteCourse(int id, [FromQuery] int courseID)
        {
            var student = dbContext.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound("Student not found");
            var course = dbContext.Courses.FirstOrDefault(c => c.Id == courseID);
            if (course == null)
                return NotFound("course not found");

            var courseToDelete = dbContext.Registrations.FirstOrDefault(c => c.Student.Id == id);
            dbContext.Registrations.Remove(courseToDelete);
            dbContext.SaveChanges();
            var studentCourses = dbContext.Registrations.Where(s => s.Student.Id == id).Select(c => c.Course).ToList();
            var studentFoundViewModel = new StudentViewModel { Student = student, Registrations = studentCourses };
            return studentFoundViewModel;
        }
        //[HttpGet("coursreg")]
        //public ActionResult<IEnumerable<Registration>> GetRegs()
        //{
        //    var courseRegs = dbContext.Registrations.ToList();
        //    return courseRegs;
        //}

    }
}
