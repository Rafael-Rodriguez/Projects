using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceMVP.DSCustomersTableAdapters;

namespace CustomerMaintenanceMVP
{
    class CustomerService
    {
        private DSCustomers _customerDataSet;

        public CustomerService(DSCustomers customerDataSet)
        {
            _customerDataSet = customerDataSet;
        }

        public void Load()
        {
            var customersTableAdapter = new CustomersTableAdapter();

            customersTableAdapter.Fill(_customerDataSet.Customers);
        }

        public void Save()
        {
            var customersTableAdapter = new CustomersTableAdapter();

            customersTableAdapter.Update(_customerDataSet.Customers);
        }
    }
}

