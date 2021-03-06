﻿using System;
using System.Collections.Generic;

namespace School.Domain.Models
{
    public class Parent
    {
        public int ParentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        public int AddressId { get; set; }

        //Navigation Property
        public virtual Address Address { get; set; }

        //Navigation Property
        // public virtual ICollection<Student> Students { get; set; }
    }
}
