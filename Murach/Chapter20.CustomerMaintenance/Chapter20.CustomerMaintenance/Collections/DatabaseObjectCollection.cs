using Chapter20.CustomerMaintenance.Database;
using System.Collections.Generic;
using System.Linq;

namespace Chapter20.CustomerMaintenance.Collections
{
    public class DatabaseObjectCollection : IDatabaseObjectCollection
    {
        private List<IDbo> dbos;

        public DatabaseObjectCollection()
        {
            CreateDbos();
        }

        private void CreateDbos()
        {
            dbos = new List<IDbo>()
            {
                new CustomerDbo()
            };
        }

        public DatabaseObjectType GetDbo<DatabaseObjectType>()
        {
            return dbos.OfType<DatabaseObjectType>().Single();
        }
    }
}
