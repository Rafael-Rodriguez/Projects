using System.Collections.Generic;
using System.Data;
using System.IO;
using Chapter21.CustomerTxtAndBinary.Models;
using Newtonsoft.Json;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class JsonWriter : ITableWriter
    {
        public string FilterString => "JSON File|*.json";

        public void WriteTable(FileStream filestream, IEnumerable<DataRow> collection)
        {
            using (var streamWriter = new StreamWriter(filestream))
            {
                var customers = new List<Customer>();
                foreach(var dataRow in collection)
                {
                    var items = dataRow.ItemArray;
                    var customer = Customer.FromItemArray(items);
                    customers.Add(customer);
                }

                var jsonCustomerArray = JsonConvert.SerializeObject(customers.ToArray());
                streamWriter.Write(jsonCustomerArray.ToString());
            }
        }
    }
}
