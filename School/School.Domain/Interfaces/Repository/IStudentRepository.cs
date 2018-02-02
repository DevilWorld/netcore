
using School.Domain.Model;
using System;
using System.Collections.Generic;

namespace School.Domain.Interfaces.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student person);
        void UpdateStudent(Student student);
        void DeletStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetStudentDetails(int intStudentId);
        void Save();
    }
}