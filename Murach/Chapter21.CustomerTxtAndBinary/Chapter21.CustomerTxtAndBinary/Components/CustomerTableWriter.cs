using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class CustomerTableWriter : ICustomerTableWriter
    {
        private List<ITableWriter> _tableWriters;

        public CustomerTableWriter()
        {
            CreateWriters();
        }

        public string FilterString { get; private set; } 

        public void WriteTable(FileStream filestream, int filterIndex, IEnumerable<DataRow> tableRowCollection)
        {
            if (filterIndex < 1 || filterIndex > (_tableWriters.Count))
            {
                throw new ArgumentOutOfRangeException(nameof(filterIndex));
            }

            _tableWriters[filterIndex - 1].WriteTable(filestream,tableRowCollection);
        }


        private void CreateWriters()
        {
            _tableWriters = new List<ITableWriter>()
            {
                new TextWriter(),
                new BinaryWriter(),
                new JsonWriter()
            };

            var sb = new StringBuilder();
            _tableWriters.ForEach(writer => 
            {
                sb.Append(writer.FilterString);
                sb.Append("|");
            });

            FilterString = sb.ToString(0, sb.Length - 1);
        }
    }
}
