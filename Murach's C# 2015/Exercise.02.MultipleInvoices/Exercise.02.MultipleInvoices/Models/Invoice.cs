using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._02.MultipleInvoices.Models
{
    public class Invoice
    {
        public decimal Subtotal { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }

        public Invoice(decimal subtotal)
        {
            Subtotal = subtotal;
            DiscountPercent = CalculateDiscountPercent(Subtotal);
            DiscountAmount = CalculateDiscountAmount(Subtotal,DiscountPercent);
            Total = CalculateTotal(Subtotal, DiscountAmount);
        }

        private decimal CalculateDiscountPercent(decimal subTotal)
        {
            var discountPercent = 0m;

            if (subTotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subTotal >= 250)
            {
                discountPercent = .15m;
            }
            else if (subTotal >= 100)
            {
                discountPercent = .1m;
            }

            return discountPercent;
        }

        private decimal CalculateDiscountAmount(decimal subtotal, decimal discountPercent)
        {
            return subtotal * discountPercent;
        }

        private decimal CalculateTotal(decimal subtotal, decimal discountAmount)
        {
            return subtotal - discountAmount;
        }
    }
}
