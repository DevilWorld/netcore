using System;
using System.Collections.Generic;

namespace School.Domain.Model
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        //Foreign key property to School
        public int SchoolId { get; set; }
        //Foreign key property to Address
        public int AddressId { get; set; }

        //Navigation Property to School
        public virtual School School { get; set; }
        //Navigation Property to Address
        public virtual Address TeacherAddress { get; set; }

        //NV to Class
        public virtual ICollection<Class> Class { get; set; }
    }
}
