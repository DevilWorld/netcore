using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Domain.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }

        public int ParentId { get; set; }
        public int AddressId { get; set; }

        //Navigation property, which acts as a collection of the child
        public virtual Address Address { get; set; }

        //Navigation property
        // public virtual Parent Parent { get; set; }

        // public virtual ICollection<StudentClass> StudentClasses { get; set; }

        // public virtual ICollection<HomeWork> HomeWork { get; set; }
    }
}
