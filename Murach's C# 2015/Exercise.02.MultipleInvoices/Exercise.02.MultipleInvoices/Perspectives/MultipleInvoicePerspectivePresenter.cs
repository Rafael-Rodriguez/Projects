using Exercise._02.MultipleInvoices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public class MultipleInvoicePerspectivePresenter
    {
        public event EventHandler<InvoiceDataEventArgs> TotalCalculated;
        public event EventHandler

        private InvoiceCollection _invoiceCollection;

        public IMultipleInvoicePerspective Perspective { get; set; }

        private InvoiceCollection InvoiceCollection
        {
            get
            {
                if(_invoiceCollection == null)
                {
                    _invoiceCollection = new InvoiceCollection();
                }

                return _invoiceCollection;
            }
        }

        public MultipleInvoicePerspectivePresenter(IMultipleInvoicePerspective perspective)
        {
            Perspective = perspective; 
        }

        public void Calculate(decimal subtotal)
        {
            var invoice = new Invoice(subtotal);

            InvoiceCollection.Add(invoice);

            if(TotalCalculated != null)
            {
                TotalCalculated(this, new InvoiceDataEventArgs(invoice.Total, invoice.DiscountPercent, invoice.DiscountAmount));
            }
        }
    }
}
