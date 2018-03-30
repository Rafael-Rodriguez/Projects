using Chapter21.CustomerTxtAndBinary.Presentation.Views;
using System.Windows.Forms;
using System.IO;
using Chapter21.CustomerTxtAndBinary.Services;
using System.Data;
using System.Collections.Generic;
using Chapter21.CustomerTxtAndBinary.Components;
using Chapter21.CustomerTxtAndBinary.Models;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Controllers
{
    public class CustomerTableController : ICustomerTableController<ICustomerTableView>
    {
        public ICustomerTableView View { get; set; }

        public CustomerTableController(IModuleController moduleController, IDialogService dialogService, ICustomerTableWriter tableWriter)
        {
            ModuleController = moduleController;
            DialogService = dialogService;
            TableWriter = tableWriter;
        }

        private ICustomerTableWriter TableWriter { get; set; }

        private IModuleController ModuleController { get; set; }

        private IDialogService DialogService { get; set; }


        public void OnSaveAsClicked(IEnumerable<DataRow> collection)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = TableWriter.FilterString;
            saveFileDialog.Title = "Save Customers";
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                SaveFile(saveFileDialog.FileName, saveFileDialog.FilterIndex, collection);
            }
        }

        private void SaveFile(string fileName, int filterIndex, IEnumerable<DataRow> collection)
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

            TableWriter.WriteTable(filestream, filterIndex, collection);
        }
    }
}
