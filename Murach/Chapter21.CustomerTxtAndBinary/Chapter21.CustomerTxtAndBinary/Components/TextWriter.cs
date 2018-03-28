using System.Collections.Generic;
using System.Data;
using System.IO;
using Chapter21.CustomerTxtAndBinary.Models;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class TextWriter : ITableWriter
    {
        public string FilterString => "Text File|*.txt";

        public void WriteTable(FileStream filestream, IEnumerable<DataRow> collection)
        {
            using (var streamWriter = new StreamWriter(filestream))
            {
                streamWriter.WriteLine(
                    $"| {"CustomerID",10} | {"Name",25} | {"Address",30} | {"City",25} | {"State",5} | {"ZipCode",10} | ");

                foreach (var dataRow in collection)
                {
                    var items = dataRow.ItemArray;
                    var customer = Customer.FromItemArray(items);
                    streamWriter.WriteLine(customer.ToString());
                }

                streamWriter.Flush();
            }
        }
    }
}
