using System.Collections.Generic;
using System.IO;
using Chapter21.CustomerTxtAndBinary.Models;
using System.Xml;

namespace Chapter21.CustomerTxtAndBinary.Components
{
    public class XmlCustomerReader : ITableReader
    {
        public string FilterString => "XML File|*.xml";

        public IList<Customer> ReadTable(FileStream filestream)
        {
            const string Customer = "Customer";

            var settings = new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document, IgnoreWhitespace = true, IgnoreComments = true };
            var customers = new List<Customer>();

            using (var reader = XmlReader.Create(filestream, settings))
            {
                if (reader.ReadToDescendant(Customer))
                {
                    do
                    {
                        reader.ReadStartElement(Customer);

                        Customer customer = new Customer();
                        
                        customer.CustomerID = reader.ReadElementContentAsInt();
                        customer.Name = reader.ReadElementContentAsString();
                        customer.Address = reader.ReadElementContentAsString();
                        customer.City = reader.ReadElementContentAsString();
                        customer.State = reader.ReadElementContentAsString();
                        customer.ZipCode = reader.ReadElementContentAsString();

                        customers.Add(customer);
                    }
                    while (reader.ReadToNextSibling(Customer));
                }
            }

            return customers;
        }
    }
}
