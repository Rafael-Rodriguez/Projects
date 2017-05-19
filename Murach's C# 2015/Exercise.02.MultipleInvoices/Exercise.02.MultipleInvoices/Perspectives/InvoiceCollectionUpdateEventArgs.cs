using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public class InvoiceCollectionUpdateEventArgs : EventArgs
    {
        public decimal TotalInvoices { get; }
        public decimal InvoiceAverage { get; }
        public int NumInvoices { get; }

        public InvoiceCollectionUpdateEventArgs(int numInvoices, decimal totalInvoices, decimal invoiceAverage)
        {
            NumInvoices = numInvoices;
            TotalInvoices = totalInvoices;
            InvoiceAverage = invoiceAverage;
        }

    }
}
