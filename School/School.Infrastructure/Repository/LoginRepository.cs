using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain.Model;
using School.Domain.Interfaces.Repository;
using School.Infrastructure;

namespace SchoolPortal.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        SchoolDataContext _context;        

        public User GetUser(User user)
        {
            using (_context = new SchoolDataContext())
            {
                return _context.Users
                        .SingleOrDefault(x => x.UserId == user.UserId && x.Password == user.Password);
            }
        }

        public bool IsUserExists(string userId)
        {
            using (_context = new SchoolDataContext())
            {
                return _context.Users.Any(x => x.UserId.Equals(userId, StringComparison.CurrentCultureIgnoreCase));
            }
        }
    }
}
