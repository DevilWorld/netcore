using Microsoft.AspNetCore.Mvc;
using School.Domain.Interfaces.Services;
using School.Domain.Models;
using School.Domain.Services;;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController()
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
            IStudentService studentService = new StudentService();

            var students = _studentService.GetAllStudents();
            return new OkObjectResult(students);
        }
    }    
}