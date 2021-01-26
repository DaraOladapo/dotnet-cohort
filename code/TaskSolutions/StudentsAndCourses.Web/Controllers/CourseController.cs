using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentsAndCourses.Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsAndCourses.Library.Models.Entity;
using StudentsAndCourses.Library.Models.ViewModels;
using StudentsAndCourses.Library.Models.Binding;
using StudentsAndCourses.Library.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentsAndCourses.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ILogger<CourseController> _logger;
        private IRepositoryWrapper repository;
        public CourseController(ILogger<CourseController> logger,IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            repository = repositoryWrapper;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public IEnumerable<CourseViewModel> Get()
        {
            var allCourses = repository.Courses.FindAll();
            List<CourseViewModel> courseViewModels = new List<CourseViewModel>();
            foreach (var course in allCourses)
            {
                courseViewModels.Add(new CourseViewModel() { Course = course });
            }
            foreach (var courseViewModel in courseViewModels)
            {
                var courseRegistations = repository.Registrations.FindByCondition(r=>r.Course.Id==courseViewModel.Course.Id).ToList();
                courseViewModel.Students = courseRegistations.Select(c => c.Student).ToList();
            }
            _logger.LogInformation($"{courseViewModels.Count} Courses gotten.");
            return courseViewModels;
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<CourseViewModel> Get(int id)
        {
            var courseFound = repository.Courses.FindByCondition(c => c.Id == id).FirstOrDefault();
            //var courseFound = dbContext.Courses.FirstOrDefault(c => c.Id == id);
            if (courseFound == null)
            {
                _logger.LogWarning($"Course with ID {id} not found.");
                return NotFound($"Course with ID {id} not found.");
            }
            _logger.LogInformation($"Course with id {id} gotten");
            var students = repository.Registrations.FindByCondition(c => c.Course.Id == id).Select(c => c.Student).ToList();
            //var students = dbContext.Registrations.Where(c => c.Course.Id == id).Select(c => c.Student).ToList();
            var courseFoundViewModel = new CourseViewModel { Course = courseFound, Students = students };
            return courseFoundViewModel;
        }

        // POST api/<CourseController>
        [HttpPost]
        public ActionResult<CourseViewModel> Post([FromBody] AddCourse course)
        {
            var existingCourse = repository.Courses.FindByCondition(c => c.Code == course.Code && c.Title == course.Title).FirstOrDefault();
            //var existingCourse = dbContext.Courses.FirstOrDefault(c => c.Code == course.Code && c.Title == course.Title);
            if (existingCourse != null)
            {
                _logger.LogError("Data conflict");
                return Conflict("Course already exists.");
            }
            if (string.IsNullOrEmpty(course.Title))
                return BadRequest("Course title is empty");
            if (string.IsNullOrEmpty(course.Code))
                return BadRequest("Course code is empty");
            var addedCourse = repository.Courses.Create(new Course { Code = course.Code, Title = course.Title });
            //var addedCourse = dbContext.Courses.Add(new Course { Code = course.Code, Title = course.Title }).Entity;
            //var addedCourse = dbContext.Courses.Add(new Course { Code = course.Code, Title = course.Title }).Entity;
            repository.Save();
            //dbContext.SaveChanges();
            return new CourseViewModel { Course = addedCourse, Students = new List<Student>() };
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult<CourseViewModel> Put(int id, [FromBody] UpdateCourse course)
        {
            var courseToUpdate = repository.Courses.FindByCondition(c => c.Id == id).FirstOrDefault();
            if (courseToUpdate == null)
            {
                _logger.LogWarning($"Course with ID {id} not found.");
                return NotFound($"Course with ID {id} not found.");
            }
            if (string.IsNullOrEmpty(course.Title))
                return BadRequest("Course title is empty");
            if (string.IsNullOrEmpty(course.Code))
                return BadRequest("Course code is empty");
            courseToUpdate.Code = course.Code;
            courseToUpdate.Title = course.Title;
            repository.Save();
            var studentsInCourse = repository.Registrations.FindByCondition(c => c.Course.Id == id).Select(c => c.Student).ToList();
            var courseFoundViewModel = new CourseViewModel { Course = courseToUpdate, Students = studentsInCourse };
            return courseFoundViewModel;
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var courseToDelete = repository.Courses.FindByCondition(c => c.Id == id).FirstOrDefault();
            if (courseToDelete == null)
            {
                _logger.LogWarning($"Course with ID {id} not found.");
                return NotFound($"Course with ID {id} not found.");
            }
            var coursesToDelete = repository.Registrations.FindByCondition(c => c.Course.Id == id);
            foreach (var course in coursesToDelete)
            {
                repository.Registrations.Delete(course);
                repository.Save();
            }
            _logger.LogCritical($"deleting course registration for {courseToDelete.Code} completed");
            repository.Courses.Delete(courseToDelete);
            repository.Save();
            _logger.LogCritical($"deleting {courseToDelete.Code} completed");
            return Ok("Course deleted");
        }
    }
}
