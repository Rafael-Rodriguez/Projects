using System;
using System.Collections.Generic;
using System.IO;
using Chapter21.CustomerTxtAndBinary.Models;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class BinaryReader : ITableReader
    {
        public string FilterString => "Binary File|*.dat";

        public IList<Customer> ReadTable(FileStream filestream)
        {
            var customers = new List<Customer>();

            using (var binaryReader = new System.IO.BinaryReader(filestream))
            {
                binaryReader.ReadString();

                while(binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
                {
                    customers.Add(GetCustomerFromBinary(binaryReader));
                }
            }

            return customers;
        }

        private Customer GetCustomerFromBinary(System.IO.BinaryReader binaryReader)
        {
            if(binaryReader == null)
            {
                throw new ArgumentNullException(nameof(binaryReader));
            }

            var customer = new Customer()
            {
                CustomerID = binaryReader.ReadInt32(),
                Name = binaryReader.ReadString(),
                Address = binaryReader.ReadString(),
                City = binaryReader.ReadString(),
                State = binaryReader.ReadString(),
                ZipCode = binaryReader.ReadString()
            };

            return customer;
        }
    }
}
