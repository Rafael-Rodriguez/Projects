using Exercise._12.ProductMaintenance.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Exercise._12.ProductMaintenance.DataLayer
{
    public class ProductDb
    {
        private const string PRODUCTS_TXT = "Products.txt";

        private BindingList<Product> products;
        public BindingList<Product> Products
        {
            get
            {
                return products;
            }
        }

        private string SaveFilePath
        {
            get
            {
                return Directory.GetCurrentDirectory() + @"\" + PRODUCTS_TXT;
            }
        }

        public void GetProducts()
        {
            var productsFromFile =
                File.ReadLines(SaveFilePath)
                .Select(line => line.Split('\t'))
                .Select(s => new Product(s[0], s[1], s[2]));
                //new Product() { Code = s[0], Price = decimal.Parse(s[1]), Description = s[2] });

            products = new BindingList<Product>(productsFromFile.ToList());
        }

        public void SaveProducts(List<Product> products)
        {
            StringBuilder productStrings = new StringBuilder(); 
            
            products.ForEach(p => productStrings.AppendLine(p.ToString()));

            File.WriteAllText(SaveFilePath, productStrings.ToString());
        }
    }
}
