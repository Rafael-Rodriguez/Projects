using Chapter21.CustomerTxtAndBinary.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class TextReader : ITableReader
    {
        public string FilterString => "Text File|*.txt";

        public IList<Customer> ReadTable(FileStream filestream)
        {
            var customers = new List<Customer>
            {
                new Customer() {Name = "Johnson", Address="silverton" }
            };

            return customers;
        }
    }
}
