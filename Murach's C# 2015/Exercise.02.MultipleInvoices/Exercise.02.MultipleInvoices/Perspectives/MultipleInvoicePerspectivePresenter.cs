using Exercise._02.MultipleInvoices.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise._02.MultipleInvoices.Perspectives
{
    public class MultipleInvoicePerspectivePresenter
    {
        public event EventHandler<InvoiceDataEventArgs> TotalCalculated;
        public event EventHandler<InvoiceCollectionUpdateEventArgs> InvoiceCollectionUpdated;

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


        /// <summary>
        /// Calculates the total, discount percent, discount amount of the given subtotal as well
        /// as update the total invoice colleciton
        /// </summary>
        /// <param name="subtotalText">Entered subtotal from perspective</param>
        /// <exception cref="ArgumentNullException">Will throw if there is string is null</exception>
        /// <exception cref="FormatException">Entered subtotal is not of currency or numeric format</exception>
        /// <exception cref="OverflowException">Entered subtotal is outside of the decimal range</exception>
        public void Calculate(string subtotalText)
        {
            decimal subtotal;

            subtotal = Decimal.Parse(subtotalText, NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture);
            subtotal = decimal.Round(subtotal, 2);

            var invoice = new Invoice(subtotal);

            if (TotalCalculated != null)
            {
                TotalCalculated(this, new InvoiceDataEventArgs(subtotal, invoice.Total, invoice.DiscountPercent, invoice.DiscountAmount));
            }

            UpdateInvoiceCollection(invoice);

            
            
        }

        private void UpdateInvoiceCollection(Invoice invoice)
        {
            InvoiceCollection.Add(invoice);

            if(InvoiceCollectionUpdated != null)
            {
                InvoiceCollectionUpdated(this, new InvoiceCollectionUpdateEventArgs(InvoiceCollection.NumInvoices, InvoiceCollection.TotalInvoices, InvoiceCollection.InvoiceAverage));
            }
        }
    }
}
