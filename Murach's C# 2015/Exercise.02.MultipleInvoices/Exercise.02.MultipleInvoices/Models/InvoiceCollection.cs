using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._02.MultipleInvoices.Models
{
    public class InvoiceCollection : ICollection<Invoice>
    {
        private List<Invoice> _invoices = new List<Invoice>();

        public decimal Total
        {
            get
            {
                return _invoices.Sum(i => i.Total);
            }
        }

        public decimal Average
        {
            get
            {
                return _invoices.Average(i => i.Total);
            }
        }

        public int Count
        {
            get
            {
                return _invoices.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(Invoice item)
        {
            _invoices.Add(item);
        }

        public void Clear()
        {
            _invoices.Clear();
        }

        public bool Contains(Invoice item)
        {
            return _invoices.Contains(item);
        }

        public void CopyTo(Invoice[] array, int arrayIndex)
        {
            _invoices.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Invoice> GetEnumerator()
        {
            return _invoices.GetEnumerator();
        }

        public bool Remove(Invoice item)
        {
            return _invoices.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
