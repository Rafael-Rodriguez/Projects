using Chapter20.CustomerMaintenance.Models;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public interface IAddCustomerView : IView
    {
        ICustomer Customer { get; set; }

        DialogResult ShowDialog();

        void SetDialogResult(DialogResult result);

        void FillStateComboBox(string[] states);
    }
}
