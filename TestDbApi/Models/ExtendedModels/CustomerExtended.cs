using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDbApi.Models.ExtendedModels
{
    public class CustomerExtended
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
 
        public virtual User CreatedBy { get; set; }
        public virtual User UpdatedBy { get; set; }

        public CustomerExtended()
        {
        }
 
        public CustomerExtended(Customer customer)
        {
            CustomerId = customer.CustomerId;
            Name = customer.Name;
            Surname = customer.Surname;
            Image = customer.Image;
        }
    }
}
