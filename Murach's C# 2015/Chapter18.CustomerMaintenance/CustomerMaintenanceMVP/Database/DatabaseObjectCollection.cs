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
            _dataAccessObjects = null;
        }

        public void CreateDataAccessObjects()
        {
            if(_dataAccessObjects != null)
            {
                return;
            }

            _dataAccessObjects = new List<IDataAccessObject>()
            {
                new CustomerDataAccessObject()
            };
        }

        public TDatabaseObjectType GetDataAccessObject<TDatabaseObjectType>()
        {
            return _dataAccessObjects.OfType<TDatabaseObjectType>().Single();
        }
    }
}
