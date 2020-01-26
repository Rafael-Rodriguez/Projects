using CustomerMaintenanceMVP.Models;
using System;

namespace CustomerMaintenanceMVP.Database
{
    public class CustomerRepository : ICustomerRepository
    {
        private MMABooksDataSet _dsMMABooks;

        public CustomerRepository(MMABooksDataSet dsMMABooks)
        {
            _dsMMABooks = dsMMABooks;
        }

        public void LoadAll()
        {
            MMABooksDataSetTableAdapters.CustomersTableAdapter customersTableAdapter = new MMABooksDataSetTableAdapters.CustomersTableAdapter();
            customersTableAdapter.Fill(_dsMMABooks.Customers);
        }

        public void Save(ICustomer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException("customer");
            }

            MMABooksDataSet.CustomersRow customerRow = _dsMMABooks?.Customers?.FindByCustomerID(customer.CustomerId) ?? null;
            if(customerRow == null)
            {
                throw new NullReferenceException("_dsMMABooks.Customers is null");
            }

            customerRow.Name = customer.Name;
            customerRow.Address = customer.Address;
            customerRow.City = customer.City;
            customerRow.State = customer.State;
            customerRow.ZipCode = customer.ZipCode;

            MMABooksDataSetTableAdapters.CustomersTableAdapter customersTableAdapter = new MMABooksDataSetTableAdapters.CustomersTableAdapter();
            customersTableAdapter.Update(_dsMMABooks.Customers.FindByCustomerID(customer.CustomerId));
        }

        public void SaveAll()
        {
            MMABooksDataSetTableAdapters.CustomersTableAdapter customersTableAdapter = new MMABooksDataSetTableAdapters.CustomersTableAdapter();
            customersTableAdapter.Update(_dsMMABooks.Customers);
        }
    }
}
