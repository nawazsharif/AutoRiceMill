using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataAccessor
{
    class CustomerDataAccessor
    {
        private TRMDBContext context;
        public CustomerDataAccessor(TRMDBContext context)
        {
            this.context = context;
        }

        public void Insert(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Customer c = context.Customers.SingleOrDefault(x => x.id == id);
            context.Customers.Remove(c);
            context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            Customer c = context.Customers.SingleOrDefault(x => x.id == customer.id);

            //c.CompanyName = company.CompanyName;
            //c.Location = company.Location;
            //c.Mail = company.Mail;
            //c.Phone = company.Phone;
            //c.TotalRevenue = company.TotalRevenue;
            //c.TotalExpense = company.TotalExpense;
            //c.Profit = company.Profit;

            context.SaveChanges();
        }

        public Customer Get(int id)
        {
            return context.Customers.SingleOrDefault(x => x.id == id);
        }
        public Customer Get(string num)
        {
            return context.Customers.SingleOrDefault(x => x.Phone == num);
        }

        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.ToList();
        }
    }
}
