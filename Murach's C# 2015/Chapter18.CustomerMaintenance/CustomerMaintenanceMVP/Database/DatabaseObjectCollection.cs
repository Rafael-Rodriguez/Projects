using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CustomerMaintenanceMVP.Database
{
    public class DatabaseObjectCollection : IDatabaseObjectCollection
    {
        private List<IDataAccessObject> _dataAccessObjects;

        public DatabaseObjectCollection()
        {
            CreateDataAccessObjects();
        }

        public TDatabaseObjectType GetDataAccessObjects<TDatabaseObjectType>()
        {
            return _dataAccessObjects.OfType<TDatabaseObjectType>().Single();
        }

        private void CreateDataAccessObjects()
        {
            _dataAccessObjects = new List<IDataAccessObject>()
            {
                new CustomerDataAccessObject()
            };
        }

        
    }
}
