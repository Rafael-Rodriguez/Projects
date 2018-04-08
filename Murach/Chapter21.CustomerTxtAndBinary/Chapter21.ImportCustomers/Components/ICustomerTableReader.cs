using Chapter21.CustomerTxtAndBinary.Models;
using System.Collections.Generic;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public interface ICustomerTableReader
    {
        string FilterString { get; }

        IList<Customer> ReadCustomers(FileStream filestream, int filterIndex);
    }
}
