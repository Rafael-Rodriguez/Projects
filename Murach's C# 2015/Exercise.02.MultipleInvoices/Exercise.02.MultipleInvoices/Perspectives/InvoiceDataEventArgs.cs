using System;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public class InvoiceDataEventArgs : EventArgs
    {
        public decimal Total { get; }
        public decimal DiscountPercent { get; }
        public decimal DiscountAmount { get; }

        public InvoiceDataEventArgs(decimal total, decimal discountPercent, decimal discountAmount)
        {
            Total = total;
            DiscountPercent = discountPercent;
            DiscountAmount = discountAmount;
        }
    }
}
