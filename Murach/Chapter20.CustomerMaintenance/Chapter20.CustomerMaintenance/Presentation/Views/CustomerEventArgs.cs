using System;
using Chapter20.CustomerMaintenance.Models;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public class CustomerEventArgs : EventArgs
    {
        public CustomerEventArgs(Customer customer)
        {
            Customer = customer;
        }

        public Customer Customer { get; set; }
    }
}
