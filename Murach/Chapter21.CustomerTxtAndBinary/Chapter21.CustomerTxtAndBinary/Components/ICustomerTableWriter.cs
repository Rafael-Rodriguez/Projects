using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public interface ICustomerTableWriter
    {
        string FilterString { get; }

        void WriteTable(FileStream filestream, int filterIndex, IEnumerable<DataRow> tableRowCollection);
    }
}
