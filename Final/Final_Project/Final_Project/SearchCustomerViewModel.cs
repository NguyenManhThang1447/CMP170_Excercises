using Final_Project1;
using Final_Project;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Final_Project
{
    public class SearchCustomerViewModel : BaseViewModel
    {
        public class Customer
        {
            public int id { get; set; }
            public string fullname { get; set; }
            public string gender { get; set; }
            public string marketplace { get; set; }
            public string email { get; set; }
            public string address { get; set; }
        }
        private string m_searchKeyword;
        public string SearchKeyword
        {
            get => m_searchKeyword;
            set
            {
                m_searchKeyword = value;
                OnPropertyChanged(nameof(m_searchKeyword));
            }
        }
        private string m_selectedmarketplace;

        public string Selectedmarketplace 
        {
            get => m_selectedmarketplace;
            set
            {
                m_selectedmarketplace = value;
                OnPropertyChanged(nameof(m_selectedmarketplace));
            }
        }
        private Customer m_selectedCustomer;
        public Customer SelectedCustomer
        {
            get => m_selectedCustomer;
            set
            {
                m_selectedCustomer = value;
                OnPropertyChanged(nameof(m_selectedCustomer));
            }
        }

        public void DoOpenDetail()
        {
            var customerDetailViewModel = new CustomerDetailViewModel(SelectedCustomer);
            Window1 customerDetail = new Window1();
            customerDetail.DataContext = customerDetailViewModel;
            customerDetail.ShowDialog();
        }

        public void DoReset()
        {
            Customers.Clear();
            SearchKeyword = null;
            Selectedmarketplace = null;
        }
        private void DoSearch()
        {
            Customers.Clear();
            var result = m_customerSrv.SearchCustomer(SearchKeyword, Selectedmarketplace);
            foreach (var s in result)
            {
                Customers.Add(s);
            }
        }

        public ObservableCollection<Customer> Customers { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand OpenDetailCommand { get; set; }
        
        private ICustomerService m_customerSrv;
        public SearchCustomerViewModel()
        {
            m_customerSrv = new CustomerServiceWithEF();
            Customers = new ObservableCollection<Customer>(m_customerSrv.SearchCustomer(string.Empty, string.Empty));
            OpenDetailCommand = new ConditionalCommand(x => DoOpenDetail());
            SearchCommand = new ConditionalCommand(x => DoSearch());
            ResetCommand = new ConditionalCommand(x => DoReset());
        }
    }
}