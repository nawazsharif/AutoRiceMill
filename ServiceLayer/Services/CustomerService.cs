using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using ServiceLayer.IServices;
using DataLayer.IDataAccessor;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerDataAccessor accessor;
        public CustomerService (ICustomerDataAccessor accessor)
        {
            this.accessor = accessor;
            
        }


        public void Delete(int id)
        {
            accessor.Delete(id);
        }

        public Customer Get(int id)
        {
            return accessor.Get(id);
        }
        public Customer Get(string num)
        {
            return accessor.Get(num);
        }

        public IEnumerable<Customer> GetAll()
        {
            return accessor.GetAll();
        }

        public void Insert(Customer customer)
        {
            accessor.Insert(customer);
        }

        public void Update(Customer customer)
        {
            accessor.Update(customer);
        }
    }
}
