using System;
using System.Collections.Generic;

namespace School.Domain.Model
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        //Navigation property for class
        public virtual ICollection<Class> Class { get; set; }
    }
}
