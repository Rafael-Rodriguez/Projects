using Chapter21.CustomerTxtAndBinary.Presentation.Views;
using System.Windows.Forms;
using System.IO;
using Chapter21.CustomerTxtAndBinary.Services;
using System.Data;
using System.Collections.Generic;
using Chapter21.CustomerTxtAndBinary.Models;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Controllers
{
    public class CustomerTableController : ICustomerTableController<ICustomerTableView>
    {
        public ICustomerTableView View { get; set; }

        public CustomerTableController(IModuleController moduleController, IDialogService dialogService)
        {
            ModuleController = moduleController;
            DialogService = dialogService;
        }

        private IModuleController ModuleController { get; set; }
        private IDialogService DialogService { get; set; }


        public void OnSaveAsClicked(IEnumerable<DataRow> collection)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt|Binary File|*.dat|JSON File|*.json";
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

            using (var streamWriter = new StreamWriter(filestream))
            {
                streamWriter.WriteLine(string.Format( "| {0,10} | {1,25} | {2,30} | {3,25} | {4,5} | {5,10} | ", "CustomerID", "Name", "Address", "City", "State", "ZipCode"));

                foreach (DataRow dataRow in collection)
                {
                    var items = dataRow.ItemArray;
                    var customer = Customer.FromItemArray(items);
                    streamWriter.WriteLine(customer.ToString());
                }

                streamWriter.Flush();
            }
        }
    }
}
