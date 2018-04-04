using Chapter21.CustomerTxtAndBinary.Models;
using System.Collections.Generic;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public interface ITableReader
    {
        string FilterString { get; }

        IList<Customer> ReadTable(FileStream filestream);
    }
}
