using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Model
{
    public class StudentClass
    {
        public int StudentClassId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
