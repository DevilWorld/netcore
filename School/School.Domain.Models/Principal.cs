using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Model
{
    public class Principal
    {
        public int PrincipalId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }        

        //public int? SchoolId { get; set; }

        public PrincipalAddress PrincipalAddress { get; set; }

        //one to one for school with principal
        //public School School { get; set; }
    }
}
