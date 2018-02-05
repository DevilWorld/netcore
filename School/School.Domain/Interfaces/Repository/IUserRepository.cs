using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain.Model;

namespace School.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        bool IsUserExists(string userName);
        // User GetUser(User user);
    }
}
