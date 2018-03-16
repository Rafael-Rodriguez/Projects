using System;
using Chapter20.CustomerMaintenance.Models;

namespace Chapter20.CustomerMaintenance.Views
{
    public class CustomerEventArgs : EventArgs
    {
        public Customer Customer { get; set; }
    }
}
