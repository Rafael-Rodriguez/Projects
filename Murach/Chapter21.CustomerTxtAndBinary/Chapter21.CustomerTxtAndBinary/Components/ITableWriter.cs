﻿using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public interface ITableWriter
    { 
        string FilterString { get; }

        void WriteTable(FileStream filestream, IEnumerable<DataRow> tableRowCollection);
    }
}
