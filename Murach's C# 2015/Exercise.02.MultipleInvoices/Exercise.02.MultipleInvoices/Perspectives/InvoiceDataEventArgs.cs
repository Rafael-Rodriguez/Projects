﻿using System;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public class InvoiceDataEventArgs : EventArgs
    {
        public decimal Subtotal { get; set; }
        public decimal Total { get; }
        public decimal DiscountPercent { get; }
        public decimal DiscountAmount { get; }
        
        public InvoiceDataEventArgs(decimal subtotal, decimal total, decimal discountPercent, decimal discountAmount)
        {
            Subtotal = subtotal;
            Total = total;
            DiscountPercent = discountPercent;
            DiscountAmount = discountAmount;
        }
    }
}
