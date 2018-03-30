using System;
using Chapter21.CustomerTxtAndBinary.Presentation.Views;
using System.Windows.Forms;
using Chapter21.CustomerTxtAndBinary.Services;
using Chapter21.CustomerTxtAndBinary.Components;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Controllers
{
    public class ImportCustomersController : IImportCustomerController<IImportCustomersView>
    {

        public ImportCustomersController(IModuleController moduleController, IDialogService dialogService, ICustomerTableWriter tableWriter)
        {
            ModuleController = moduleController;
            DialogService = dialogService;
            TableWriter = tableWriter;
        }

        public IImportCustomersView View { get; set; }

        private ICustomerTableWriter TableWriter { get; set; }

        private IModuleController ModuleController { get; set; }

        private IDialogService DialogService { get; set; }

        public void OnImportCustomersClicked()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = TableWriter.FilterString;
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
            
        }
    }
}
