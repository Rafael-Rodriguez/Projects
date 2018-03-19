using Chapter20.CustomerMaintenance.Database;
using System.Collections.Generic;
using System.Linq;

namespace Chapter20.CustomerMaintenance.Collections
{
    public class DatabaseObjectCollection : IDatabaseObjectCollection
    {
        private List<IDbo> _dbos;

        public DatabaseObjectCollection()
        {
            CreateDbos();
        }

        private void CreateDbos()
        {
            _dbos = new List<IDbo>()
            {
                new CustomerDbo()
            };
        }

        public TDatabaseObjectType GetDbo<TDatabaseObjectType>()
        {
            return _dbos.OfType<TDatabaseObjectType>().Single();
        }
    }
}
