using System;

namespace Chapter23.CustomerInvoice.Models
{
    public sealed class Invoice : IInvoice
    {
        public int CustomerID { get; set; }

        public int InvoiceID { get; set; }

        public float InvoiceTotal { get; set; }

        public float ProductTotal { get; set; }

        public float SalesTax { get; set; }

        public float Shipping { get; set; }

        public DateTime InvoiceDate { get; set; }
    }
}
