using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SchoolPortal.Domain.Interfaces.Repository;
using SchoolPortal.Domain.Model;
using System.Data.Entity.Validation;

namespace SchoolPortal.Infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {

        EFDataContext _context;

        public void AddStudent(Student student)
        {
            using (_context = new EFDataContext())
            {
                _context.Students.Add(student);
            }
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }

        public void DeletStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Deleted;
        }
        
        public IEnumerable<Student> GetAllStudents()
        {
            using (_context = new EFDataContext())
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
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbex)
            {
                foreach (var ex in dbex.EntityValidationErrors)
                {
                    foreach (var e in ex.ValidationErrors)
                    {
                        var property = e.PropertyName;
                        var error = e.ErrorMessage;
                    }
                }
            }
        }
    }
}
