using System;
using System.Collections.Generic;
using System.Text;

namespace IMS.Domain.Models.Security
{
    public class TokenRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
