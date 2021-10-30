using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_Project.SearchCustomerViewModel;

namespace Final_Project
{
    class CustomerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=CustomerDB_EFCore;MultipleActiveResultSets=true;Trusted_Connection=true;Integrated Security=true;");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
