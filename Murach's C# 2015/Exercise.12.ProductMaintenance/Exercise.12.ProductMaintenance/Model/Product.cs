using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._12.ProductMaintenance.Model
{
    public class Product
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Product(string code, string price, string description)
        {
            Code = code;
            Price = decimal.Parse(price, System.Globalization.NumberStyles.AllowCurrencySymbol | System.Globalization.NumberStyles.AllowDecimalPoint);
            Description = description;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}", Code, Price, Description);
        }
    }
}
