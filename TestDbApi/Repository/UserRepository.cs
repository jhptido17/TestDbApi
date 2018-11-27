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
    }
}
