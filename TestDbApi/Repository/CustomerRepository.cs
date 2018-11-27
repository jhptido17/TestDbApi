using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDbApi.Interface;
using TestDbApi.Models;
using TestDbApi.Data;

namespace TestDbApi.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(TheCRMContext theCRMContext) : base(theCRMContext)
        {

        }
    }
}
