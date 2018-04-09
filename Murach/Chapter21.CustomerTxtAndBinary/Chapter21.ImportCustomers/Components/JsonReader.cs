using System.Collections.Generic;
using System.IO;
using Chapter21.CustomerTxtAndBinary.Models;
using Newtonsoft.Json;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class JsonReader : ITableReader
    {
        public string FilterString => "JSON File|*.json";

        public IList<Customer> ReadTable(FileStream filestream)
        {
            var customers = new List<Customer>();

            using (var streamReader = new StreamReader(filestream))
            {
                var json = streamReader.ReadToEnd();
                var customerArray = JsonConvert.DeserializeObject<Customer[]>(json);

                customers.AddRange(customerArray);
            }

            return customers;
        }

        
    }
}
