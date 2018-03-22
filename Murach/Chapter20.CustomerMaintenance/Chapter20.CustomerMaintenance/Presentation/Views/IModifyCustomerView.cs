using Chapter20.CustomerMaintenance.Models;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    interface IModifyCustomerView
    {
        Customer Customer { get; set; }
        DialogResult ShowDialog();
    }
}
