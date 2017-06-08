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

        public string GetDisplayText(string seperator = "\t")
        {

        }
    }
}
