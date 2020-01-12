using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter18.CustomerMaintenance
{
    public partial class CustomerMaintenance : Form
    {
        public CustomerMaintenance()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void CustomerMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.mMABooksDataSet.Customers);

        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(zipCodeTextBox.Text, @"[0-9]*\-?[0-9]*\s*$"))
            {
                errorProvider.SetError(zipCodeTextBox, "Only numeric values allowed");
                zipCodeTextBox.Undo();
                zipCodeTextBox.Focus();
            }
            else
            {
                errorProvider.SetError(zipCodeTextBox, null);
            }

            
        }
    }
}
