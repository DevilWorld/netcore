using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Domain.Model
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

        //Navigation property, which acts as a collection of the child
        public virtual ICollection<Address> Addresses { get; set; }

        //Navigation property
        public virtual ICollection<Parent> Parents { get; set; }

        public virtual ICollection<StudentClass> StudentClasses { get; set; }

        public virtual ICollection<HomeWork> HomeWork { get; set; }
    }
}
