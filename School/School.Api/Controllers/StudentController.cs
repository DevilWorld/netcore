using Microsoft.AspNetCore.Mvc;
using School.Domain.Interfaces.Services;
using School.Domain.Model;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController( IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost()]
        public IActionResult AddStudent(Student student)
        {
            _studentService.AddStudent(student);
            return new CreatedResult("Add Student", "Success");
        }

        [HttpGet("all-students")]
        public IActionResult GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            return new OkObjectResult(students);
        }
    }    
}