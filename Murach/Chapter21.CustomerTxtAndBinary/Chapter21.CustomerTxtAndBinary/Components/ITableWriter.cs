using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public interface ITableWriter
    {
        void WriteTable(FileStream filestream, IEnumerable<DataRow> tableRowCollection);
    }
}
