using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDbApi.Models;
using TestDbApi.Interface;
using TestDbApi.Data;

namespace TestDbApi.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(TheCRMContext theCRMContext) : base(theCRMContext)
        {
        }

        public IEnumerable<User> GetAllUsers()
        {
            return FindAll().OrderBy(us => us.Username);
        }

        public User GetUserById(Guid userId)
        {
            return FindByCondition(user => user.UserId.Equals(userId))
                .DefaultIfEmpty(new User())
                .FirstOrDefault();
        }
    }
}
