using System.Collections.Generic;
using School.Domain.Interfaces.Services;
using School.Domain.Model;
using School.Domain.Interfaces.Repository;

namespace School.Domain.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }
    }
}