using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentsAndScores.Library.Data;
using StudentsAndScores.Library.Models.ViewModels;
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
        public StudentController(ILogger<StudentController> logger, ApplicationDbContext applicationDb)
        {
            _logger = logger;
            dbContext = applicationDb;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<StudentViewModel> Get()
        {
            var allStudents = dbContext.Students.ToList();
            var allRegistrations = dbContext.Registrations.ToList();
            List<StudentViewModel> studentViewModels = new List<StudentViewModel>();
            foreach (var student in allStudents)
            {
                studentViewModels.Add(new StudentViewModel() { Student = student });
            }
            foreach (var studentViewModel in studentViewModels)
            {
                foreach (var registration in allRegistrations)
                {
                    if (registration.Student.Id == studentViewModel.Student.Id)
                        studentViewModel.Registrations.Add(registration.Course);
                }
            }
            return studentViewModels;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
