using Chapter23.CustomerInvoice.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Chapter23.CustomerInvoice.Database
{
    public sealed class InvoicesDataAccessObject : IInvoicesDataAccessObject
    {
        public IList<Invoice> GetInvoices()
        {
            var connection = new SqlConnection(Properties.Settings.Default.MMABooksConnectionString);
            const string selectStatement = "SELECT InvoiceID, CustomerID, InvoiceDate, ProductTotal, SalesTax, ShippingTotal, InvoiceTotal" +
                                            "FROM Invoices";
            var selectCommand = new SqlCommand(selectStatement, connection);

            var invoices = new List<Invoice>();

            try
            {
                connection.Open();
                using (var invoiceReader = selectCommand.ExecuteReader())
                {
                    if (invoiceReader.HasRows)
                    {
                        while (invoiceReader.Read())
                        {
                            var invoice = new Invoice
                            {
                                InvoiceID = (int)invoiceReader["InvoiceID"],
                                CustomerID = (int)invoiceReader["CustomerID"],
                                InvoiceDate = invoiceReader.GetDateTime(2),
                                ProductTotal = (float) invoiceReader["ProductTotal"],
                                SalesTax = (float) invoiceReader["SalesTax"],
                                Shipping = (float) invoiceReader["Shipping"],
                                InvoiceTotal = (float) invoiceReader["InvoiceTotal"]
                            };

                            invoices.Add(invoice);
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }

            return invoices;
        }
    }
}
