using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class CustomerTableWriter : ITableWriter
    {
        private int _filterIndex;

        public CustomerTableWriter(int filterIndex)
        {
            _filterIndex = filterIndex;
        }

        public void WriteTable(FileStream filestream, IEnumerable<DataRow> tableRowCollection)
        {
            
        }
    }
}
