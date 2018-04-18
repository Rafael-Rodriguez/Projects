using System.Collections.Generic;
using System.Linq;

namespace Chapter23.CustomerInvoice.Database
{
    public class DatabaseObjectCollection : IDatabaseObjectCollection
    {
        public List<IDbo> _dbos;

        public DatabaseObjectCollection()
        {
            CreateDbos();
        }

        private void CreateDbos()
        {
            _dbos = new List<IDbo>
            {
                new CustomersDbo(),
                new InvoicesDbo()
            };
        }

        public TDatabaseObjectType GetDbo<TDatabaseObjectType>()
        {
            return _dbos.OfType<TDatabaseObjectType>().Single();
        }
    }
}
