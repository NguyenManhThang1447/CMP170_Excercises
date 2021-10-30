using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_Project.SearchCustomerViewModel;

namespace Final_Project
{
    public class CustomerServiceWithFile : ICustomerService
    {
        private List<Customer> m_customer;

        public Customer LoadCustomerById(long id)
        {
            throw new NotImplementedException();
        }
        public IList<Customer> SearchCustomer(string keyword, string marketplace)
        {
            var result = m_customer.Where(s => (s.marketplace == marketplace ||  marketplace == null) && (s.fullname == keyword || keyword == null))
                               .OrderBy(s => s.id).ToList();
            return result;
        }
    }
}