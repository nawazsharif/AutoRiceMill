using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IServices
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        Customer Get(string num);
        void Insert(Customer sustomer);
        void Update(Customer customer);
        void Delete(int id);


    }
}
