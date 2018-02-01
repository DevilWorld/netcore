using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolPortal.Domain.Model;
using SchoolPortal.Domain.Interfaces.Repository;

namespace SchoolPortal.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        EFDataContext _context;        

        public User GetUser(User user)
        {
            using (_context = new EFDataContext())
            {
                return _context.Users
                        .SingleOrDefault(x => x.UserId == user.UserId && x.Password == user.Password);
            }
        }

        public bool IsUserExists(string userId)
        {
            using (_context = new EFDataContext())
            {
                return _context.Users.Any(x => x.UserId.Equals(userId, StringComparison.CurrentCultureIgnoreCase));
            }
        }
    }
}
