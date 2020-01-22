using System;
using CustomerMaintenanceMVP.Database;
using CustomerMaintenanceMVP.Presentation.View;

namespace CustomerMaintenanceMVP.Presentation.Presenter
{
    public class CustomerMaintenancePresenter : IPresenter<CustomerMaintenanceView>
    {
        private IModuleController _controller;
        private IDatabaseObjectCollection _databaseObjectCollection;
        private object _syncLock = new object();

        public CustomerMaintenancePresenter(IModuleController controller)
        {
            _controller = controller;
        }

        public CustomerMaintenanceView View { get; set; }

        private IDatabaseObjectCollection DatabaseObjectCollection
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

        }
    }
}
