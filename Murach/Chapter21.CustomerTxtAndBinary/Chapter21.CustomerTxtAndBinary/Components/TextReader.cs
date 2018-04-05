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
            var customers = new List<Customer>();

            using (var streamReader = new StreamReader(filestream))
            {
                string line = streamReader.ReadLine();
                while((line = streamReader.ReadLine()) != null)
                {
                    customers.Add(GetCustomerFromLine(line));
                }
            }

            return customers;
        }

        private Customer GetCustomerFromLine(string line)
        {
            if(line == null)
            {
                throw new ArgumentNullException(nameof(line));
            }

            char[] delimiterCharacters = { '|' };

            string[] customerData = line.Split(delimiterCharacters, StringSplitOptions.RemoveEmptyEntries);

            var customer = new Customer()
            {
                CustomerID = int.Parse(customerData[0]),
                Name = customerData[1].Trim(),
                Address = customerData[2].Trim(),
                City = customerData[3].Trim(),
                State = customerData[4].Trim(),
                ZipCode = customerData[5].Trim()
            };

            return customer;
        }
    }
}
