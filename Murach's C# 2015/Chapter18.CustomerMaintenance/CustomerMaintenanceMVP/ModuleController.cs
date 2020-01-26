using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CustomerMaintenanceMVP.Database;
using CustomerMaintenanceMVP.Presentation.View;

namespace CustomerMaintenanceMVP
{
    public class ModuleController : IModuleController
    {
        private IList<IDatabaseObjectCollection> _databaseObjectCollections;
        private IList<ICustomerMaintenanceView> _views;

        public Form Run()
        {
            RegisterDatabaseObjectCollection();

            RegisterViews();

            return GetView<CustomerMaintenanceView>();
        }

        public TViewType GetView<TViewType>()
        {
            return _views.OfType<TViewType>().Single();
        }

        public TDatabaseObjectCollectionType GetCollection<TDatabaseObjectCollectionType>()
        {
            return _databaseObjectCollections.OfType<TDatabaseObjectCollectionType>().Single();
        }

        private void RegisterDatabaseObjectCollection()
        {
            _databaseObjectCollections = new List<IDatabaseObjectCollection>()
            {
                new DatabaseObjectCollection()
            };
        }

        private void RegisterViews()
        {
            _views = new List<ICustomerMaintenanceView>()
            {
                new CustomerMaintenanceView()
            };
        }
    }
}
