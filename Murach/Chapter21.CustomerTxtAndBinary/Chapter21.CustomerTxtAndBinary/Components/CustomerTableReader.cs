using Chapter21.CustomerTxtAndBinary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class CustomerTableReader : ICustomerTableReader
    {
        private List<ITableReader> _tableReaders;

        public CustomerTableReader()
        {
            CreateReaders();
        }

        public string FilterString { get; private set; }

        private void CreateReaders()
        {
            _tableReaders = new List<ITableReader>()
            {
                new TextReader()
            };

            var sb = new StringBuilder();
            _tableReaders.ForEach(writer =>
            {
                sb.Append(writer.FilterString);
                sb.Append("|");
            });

            FilterString = sb.ToString(0, sb.Length - 1);
        }

        public IList<Customer> ReadCustomers(FileStream filestream, int filterIndex)
        {
            if (filterIndex < 1 || filterIndex > (_tableReaders.Count))
            {
                throw new ArgumentOutOfRangeException(nameof(filterIndex));
            }

            return _tableReaders[filterIndex - 1].ReadTable(filestream);
        }
    }
}
