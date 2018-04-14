using System;

namespace Chapter23.CustomerInvoice.Models
{
    public interface IInvoice
    {
        int InvoiceID { get; set; }
        int CustomerID { get; set; }
        DateTime InvoiceDate { get; set; }
        float ProductTotal { get; set; }
        float SalesTax { get; set; }
        float Shipping { get; set; }
        float InvoiceTotal { get; set; }
    }
}
