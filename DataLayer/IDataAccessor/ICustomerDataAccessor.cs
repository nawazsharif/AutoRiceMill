using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.IDataAccessor
{
    public interface ICustomerDataAccessor
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        Customer Get(string num);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
    }
}
