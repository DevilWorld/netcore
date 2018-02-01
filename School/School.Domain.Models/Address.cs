using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set;}
        public int Zip { get; set; }

        //Navigation property for student
        public virtual ICollection<Student> Students { get; set; }

        //Navagation property for parent
        public virtual ICollection<Parent> Parents { get; set; }        

        //Navigation property for Teacher
        public virtual Teacher Teachers { get; set; }
    }
}
