using Final_Project;
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
    class CustomerDetailViewModel : BaseViewModel
    {

        private string marketplacedetail;
        private bool ismale1;
        private int iddetail;
        private string fullnamedetail;
        private string emaildetail;
        private string addressdetail;
        private string genderdetail;
        public int Iddetail
        {
            get => iddetail; set
            {
                iddetail = value;
                OnPropertyChanged(nameof(iddetail));

            }
        }
        public string Fullnamedetail
        {
            get => fullnamedetail; set
            {
                fullnamedetail = value;
                OnPropertyChanged(nameof(fullnamedetail));

            }
        }
        public string Addressdetail
        {
            get => addressdetail; set
            {
                addressdetail = value;
                OnPropertyChanged(nameof(Addressdetail));

            }
        }
        public string Emaildetail
        {
            get => emaildetail; set
            {
                emaildetail = value;
                OnPropertyChanged(nameof(Emaildetail));

            }
        }
        public string Genderdetail
        {
            get => genderdetail; set
            {
                genderdetail = value;
                OnPropertyChanged(nameof(Genderdetail));

            }
        }
        public string Marketplacedetail
        {
            get => marketplacedetail; set
            {
                marketplacedetail = value;

                OnPropertyChanged(nameof(Marketplacedetail));

            }
        }
        public Boolean Ismale
        {
            get => ismale1; set
            {
                ismale1 = value;
                OnPropertyChanged(nameof(Ismale));

            }
        }
        public Boolean IsFemale
        {
            get => !ismale1; set
            {
                ismale1 = !value;
                OnPropertyChanged(nameof(IsFemale));

            }
        }

        public CustomerDetailViewModel(Customer customer)
        {
            Iddetail = customer.id;
            Fullnamedetail = customer.fullname;
            Addressdetail = customer.address;
            Emaildetail = customer.email;
            Genderdetail = customer.gender;
            Marketplacedetail = customer.marketplace;
            Ismale = (Genderdetail == "Male");
        }
    }
}
