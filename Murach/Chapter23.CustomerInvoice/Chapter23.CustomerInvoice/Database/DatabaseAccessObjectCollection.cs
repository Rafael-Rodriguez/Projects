using System.Collections.Generic;
using System.Linq;

namespace Chapter23.CustomerInvoice.Database
{
    public class DatabaseAccessObjectCollection : IDatabaseAccessObjectCollection
    {
        private List<IDataAccessObject> _dataAccessObjects;

        public DatabaseAccessObjectCollection()
        {
            CreateDbos();
        }

        private void CreateDbos()
        {
            _dataAccessObjects = new List<IDataAccessObject>
            {
                new CustomersDataAccessObject(),
                new InvoicesDataAccessObject()
            };
        }

        public TDatabaseObjectType GetDataAccessObject<TDatabaseObjectType>()
        {
            return _dataAccessObjects.OfType<TDatabaseObjectType>().Single();
        }
    }
}
