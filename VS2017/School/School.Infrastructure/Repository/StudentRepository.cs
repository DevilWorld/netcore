using System;
using System.Collections.Generic;
using System.Linq;
using School.Domain.Interfaces.Repository;
using School.Domain.Models;
using School.Infrastructure;

namespace School.Infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {

        SchoolDataContext _context;

        public void AddStudent(Student student)
        {
            using (_context = new SchoolDataContext())
            {
                _context.Students.Add(student);
            }
        }

        public void UpdateStudent(Student student)
        {
            //_context.Entry(student).State = EntityState.Modified;
        }

        public void DeletStudent(Student student)
        {
            // _context.Entry(student).State = EntityState.Deleted;
        }
        
        public IEnumerable<Student> GetAllStudents()
        {
            using (_context = new SchoolDataContext())
            {
                var allPersons = _context.Students.ToList();
                return allPersons;
            }
        }

        public IEnumerable<Student> GetStudentDetails(int intStudentId)
        {
            return new List<Student>();
        }

        public void Save()
        {
            // try
            // {
                _context.SaveChanges();
            // }
            // catch (DbEntityValidationException dbex)
            // {
            //     foreach (var ex in dbex.EntityValidationErrors)
            //     {
            //         foreach (var e in ex.ValidationErrors)
            //         {
            //             var property = e.PropertyName;
            //             var error = e.ErrorMessage;
            //         }
            //     }
            // }
        }
    }
}
