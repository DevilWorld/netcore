using School.Domain.Models;
using System.Collections.Generic;

namespace School.Domain.Interfaces.Services
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        IEnumerable<Student> GetAllStudents();
    }
}