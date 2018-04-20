using System.Collections.Generic;
using Chapter23.CustomerInvoice.Models;

namespace Chapter23.CustomerInvoice.Database
{
    public interface IInvoicesDataAccessObject : IDataAccessObject
    {
        IList<Invoice> GetInvoices();
    }
}