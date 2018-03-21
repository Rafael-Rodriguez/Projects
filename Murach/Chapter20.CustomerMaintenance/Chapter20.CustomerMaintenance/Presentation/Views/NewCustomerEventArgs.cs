using System;
using Chapter20.CustomerMaintenance.Models;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public class NewCustomerEventArgs : EventArgs
    {
        public NewCustomerEventArgs(string name, string address, string city, string state, string zipCode)
        {
            Name = name;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string Name;
        public string Address;
        public string City;
        public string State;
        public string ZipCode;
    }
}
