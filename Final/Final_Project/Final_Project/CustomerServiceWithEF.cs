using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_Project.SearchCustomerViewModel;

namespace Final_Project

{
    public class CustomerServiceWithEF : ICustomerService
    {
        public CustomerServiceWithEF()
        {
            using (var ctx = new CustomerContext())
            {
                ctx.Database.EnsureCreated();
            }
        }

        public Customer LoadCustomerById(long id)
        {
            using (var ctx = new CustomerContext())
            {
                return ctx.Customers.FirstOrDefault(s => s.id == id);
            }
        }

        public IList<Customer> SearchCustomer(string keyword, string Marketplace)
        {
            using (var ctx = new CustomerContext())
            {
                var result = ctx.Customers.Where(s => (s.marketplace == Marketplace || Marketplace == null) && (s.fullname == keyword || keyword == null))
                   .OrderBy(s => s.id).ToList();

                return result;
            }
        }
    }
}