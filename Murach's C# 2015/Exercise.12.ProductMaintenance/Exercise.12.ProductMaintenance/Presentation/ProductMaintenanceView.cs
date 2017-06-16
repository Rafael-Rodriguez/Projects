using Exercise._12.ProductMaintenance.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise._12.ProductMaintenance
{
    public partial class ProductMaintenanceView : Form
    {
        private ProductDb productDb;

        public ProductMaintenanceView()
        {
            InitializeComponent();
            productDb = new ProductDb();
            productDb.GetProducts();

            lstBoxProducts.DataSource = productDb.Products;
        }
    }
}
