using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Final_Project.SearchCustomerViewModel;

namespace Final_Project
{
    public interface ICustomerService
    {
        IList<Customer> SearchCustomer(string keyword, string marketplace);
        Customer LoadCustomerById(long id);
    }
}
