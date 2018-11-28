using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDbApi.Interface;
using TestDbApi.Models;
using TestDbApi.Data;
using TestDbApi.Models.ExtendedModels;

namespace TestDbApi.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(TheCRMContext theCRMContext) : base(theCRMContext)
        {
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return FindAll().OrderBy(cu => cu.Name);
        }

        public Customer GetCustomerById(Guid customerId)
        {
            return FindByCondition(customer => customer.CustomerId.Equals(customerId))
                .DefaultIfEmpty(new Customer())
                .FirstOrDefault();
        }

        public CustomerExtended GetCustomerWithDetails(Guid customerId)
        {
            return new CustomerExtended(GetCustomerById(customerId))
            {
                //CreatedBy = TheCRMContext.Users
                //.Where(a => a.OwnerId == ownerId),
                //UpdatedBy = FindByCondition(user => user.UpdatedBy.Username);

                //var customers = _repoWrapper.Customer.FindByCondition(x => x.CreatedBy.Username.Equals("user1"));
            };
        }
    }
}
