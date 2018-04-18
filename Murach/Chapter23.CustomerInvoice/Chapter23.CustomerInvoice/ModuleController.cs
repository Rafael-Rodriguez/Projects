using Chapter23.CustomerInvoice.Database;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chapter23.CustomerInvoice
{
    public class ModuleController : IModuleController
    {
        private IList<IView> _views;
        private IList<IDatabaseObjectCollection> _databaseObjectCollections;

        public Form Run()
        {
            RegisterDatabaseObjectCollections();

            RegisterViews();

            return GetView<CustomerInvoicesView>();
        }

        private void RegisterDatabaseObjectCollections()
        {
            _databaseObjectCollections = new List<IDatabaseObjectCollection>
            {
                new DatabaseObjectCollection()
            };
        }

        private void RegisterViews()
        {
            _views = new List<IView>
            {
                new CustomerInvoicesView(new CustomerInvoicesController(this))
            };
        }

        public TViewType GetView<TViewType>()
        {
            return _views.OfType<TViewType>().Single();
        }

        public TCollectionType GetCollection<TCollectionType>()
        {
            return _databaseObjectCollections.OfType<TCollectionType>().Single();
        }
    }
}
