using System;
using CustomerMaintenanceMVP.Database;
using CustomerMaintenanceMVP.Models;
using CustomerMaintenanceMVP.Presentation.View;

namespace CustomerMaintenanceMVP.Presentation.Presenter
{
    public class CustomerMaintenancePresenter
    {
        private IModuleController _controller;
        private readonly ICustomerMaintenanceView _view;
        private IDatabaseObjectCollection _databaseObjectCollection;
        private object _syncLock = new object();

        public CustomerMaintenancePresenter(/*IModuleController controller,*/ ICustomerMaintenanceView view)
        {
            //_controller = controller;
            _view = view;
        }

        public ICustomerMaintenanceView View
        {
            get
            {
                return _view;
            }
        }

        public void LoadCustomers()
        {
            CustomerRepository customerRepository = new CustomerRepository(View.DSMMABooks);
            customerRepository.LoadAll();
        }


        public void SaveCustomer(ICustomer customer)
        {
            CustomerRepository customerRepository = new CustomerRepository(View.DSMMABooks);
            customerRepository.Save(customer);
        }

        public void SaveAllCustomers()
        {
            CustomerRepository customerRepository = new CustomerRepository(View.DSMMABooks);
            customerRepository.SaveAll();
        }



        /*private IDatabaseObjectCollection DatabaseObjectCollection
        {
            get
            {
                if(_databaseObjectCollection != null)
                {
                    lock(_syncLock)
                    {
                        _databaseObjectCollection = _controller.GetCollection<IDatabaseObjectCollection>();
                    }
                }

                return _databaseObjectCollection;
            }
        }

        public void OnLoad()
        {
            DatabaseObjectCollection.CreateDataAccessObjects();

            LoadCustomers();
        }

        private void LoadCustomers()
        {
            DatabaseObjectCollection.GetDataAccessObject<ICustomerDataAccessObject>().GetCustomers();

        }*/
    }
}
