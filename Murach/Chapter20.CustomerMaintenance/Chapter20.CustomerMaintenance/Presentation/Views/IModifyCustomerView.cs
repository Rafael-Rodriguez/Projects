using Chapter20.CustomerMaintenance.Models;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public interface IModifyCustomerView : IView
    {
        ICustomer Customer { get; set; }

        DialogResult ShowDialog(ICustomer customer);

        void FillStateComboBox(string[] states);
    }
}
