using System;
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
            using (var streamWriter = new System.IO.StreamWriter(filestream))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;
                    jsonWriter.IndentChar = '\t';

                    foreach (var dataRow in collection)
                    {
                        var items = dataRow.ItemArray;
                        var customer = Customer.FromItemArray(items);

                        jsonWriter.WriteStartObject();
                        jsonWriter.WritePropertyName("CustomerID");
                        jsonWriter.WriteValue(customer.CustomerID);
                        jsonWriter.WritePropertyName("Name");
                        jsonWriter.WriteValue(customer.Name);
                        jsonWriter.WritePropertyName("Address");
                        jsonWriter.WriteValue(customer.Address);
                        jsonWriter.WritePropertyName("City");
                        jsonWriter.WriteValue(customer.City);
                        jsonWriter.WritePropertyName("State");
                        jsonWriter.WriteValue(customer.State);
                        jsonWriter.WritePropertyName("ZipCode");
                        jsonWriter.WriteValue(customer.ZipCode);
                        jsonWriter.WriteEndObject();

                        streamWriter.WriteLine();
                    }

                    jsonWriter.Flush();
                }
                    
            }
        }
    }
}
