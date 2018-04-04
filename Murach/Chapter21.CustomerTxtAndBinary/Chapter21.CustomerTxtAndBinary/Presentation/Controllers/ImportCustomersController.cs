using System;
using Chapter21.CustomerTxtAndBinary.Presentation.Views;
using System.Windows.Forms;
using Chapter21.CustomerTxtAndBinary.Services;
using Chapter21.CustomerTxtAndBinary.Components;
using System.IO;
using System.Collections.Generic;
using Chapter21.CustomerTxtAndBinary.Models;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Controllers
{
    public class ImportCustomersController : IImportCustomerController<IImportCustomersView>
    {

        public ImportCustomersController(IModuleController moduleController, IDialogService dialogService, ICustomerTableReader tableReader)
        {
            ModuleController = moduleController;
            DialogService = dialogService;
            TableReader = tableReader;
        }

        public IImportCustomersView View { get; set; }

        private ICustomerTableReader TableReader { get; set; }

        private IModuleController ModuleController { get; set; }

        private IDialogService DialogService { get; set; }

        public void OnImportCustomersClicked()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = TableReader.FilterString;
            openFileDialog.Title = "Import Customers";
            openFileDialog.Multiselect = false;
            var result = openFileDialog.ShowDialog();

            if(result == DialogResult.Cancel)
            {
                return;
            }

            if(openFileDialog.FileName != "")
            {
                OpenFile(openFileDialog.FileName, openFileDialog.FilterIndex);
            }
        }

        private void OpenFile(string fileName, int filterIndex)
        {
            FileStream filestream;
            try
            {
                filestream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            }
            catch (IOException)
            {
                return;
            }

            var customers = TableReader.ReadCustomers(filestream, filterIndex);
            View.DataGrid.DataSource = customers;
        }
    }
}
