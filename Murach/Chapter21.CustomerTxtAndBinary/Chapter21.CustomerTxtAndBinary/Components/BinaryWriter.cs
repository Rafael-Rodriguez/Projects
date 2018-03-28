using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class BinaryWriter : ITableWriter
    {
        public string FilterString => "Binary File|*.dat";

        public void WriteTable(FileStream filestream, IEnumerable<DataRow> tableRowCollection)
        {
            throw new System.NotImplementedException();
        }
    }
}
