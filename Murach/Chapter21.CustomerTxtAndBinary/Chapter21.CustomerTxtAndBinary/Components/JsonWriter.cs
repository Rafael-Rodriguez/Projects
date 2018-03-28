using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class JsonWriter : ITableWriter
    {
        public string FilterString => "JSON File|*.json";

        public void WriteTable(FileStream filestream, IEnumerable<DataRow> tableRowCollection)
        {
            throw new System.NotImplementedException();
        }
    }
}
