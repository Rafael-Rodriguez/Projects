using System;
using Chapter20.CustomerMaintenance.Models;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public class NewCustomerEventArgs : EventArgs
    {
        public NewCustomerEventArgs(string name, string address, string city, string stateCode, string zipCode)
        {
            Name = name;
            Address = address;
            City = city;
            StateCode = stateCode;
            ZipCode = zipCode;
        }

        public string Name;
        public string Address;
        public string City;
        public string StateCode;
        public string ZipCode;
    }
}
