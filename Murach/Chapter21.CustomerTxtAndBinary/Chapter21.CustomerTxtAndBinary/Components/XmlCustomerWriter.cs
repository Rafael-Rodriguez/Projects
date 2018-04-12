using Chapter21.CustomerTxtAndBinary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class XmlCustomerWriter : ITableWriter
    {
        public string FilterString => "XML File|*.xml";

        public void WriteTable(FileStream filestream, IEnumerable<DataRow> tableRowCollection)
        {
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, IndentChars = "     " };
            using (XmlWriter writer = XmlWriter.Create(filestream, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Customers");

                foreach (var dataRow in tableRowCollection)
                {
                    var items = dataRow.ItemArray;
                    var customer = Customer.FromItemArray(items);

                    writer.WriteStartElement("Customer");

                    writer.WriteElementString("CustomerID", Convert.ToString(customer.CustomerID));
                    writer.WriteElementString("Name", customer.Name);
                    writer.WriteElementString("Address", customer.Address);
                    writer.WriteElementString("City", customer.City);
                    writer.WriteElementString("State", customer.State);
                    writer.WriteElementString("ZipCode", customer.ZipCode);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Flush();
            }
        }
    }
}
