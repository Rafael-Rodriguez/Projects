using Chapter21.CustomerTxtAndBinary.Models;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class BinaryWriter : ITableWriter
    {
        public string FilterString => "Binary File|*.dat";

        public void WriteTable(FileStream filestream, IEnumerable<DataRow> collection)
        {
            using (var binaryWriter = new System.IO.BinaryWriter(filestream))
            {
                binaryWriter.Write($" | { "CustomerID",10} | { "Name",25} | { "Address",30} | { "City",25} | { "State",5} | { "ZipCode",10} | ");

                foreach (var dataRow in collection)
                {
                    var items = dataRow.ItemArray;
                    var customer = Customer.FromItemArray(items);
                    binaryWriter.Write(customer.CustomerID);
                    binaryWriter.Write(customer.Name);
                    binaryWriter.Write(customer.Address);
                    binaryWriter.Write(customer.City);
                    binaryWriter.Write(customer.State);
                    binaryWriter.Write(customer.ZipCode);
                }

                binaryWriter.Flush();
            }
        }
    }
}
