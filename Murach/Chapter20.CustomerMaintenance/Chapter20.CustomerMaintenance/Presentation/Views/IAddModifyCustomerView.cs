using Chapter20.CustomerMaintenance.Models;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public interface IAddModifyCustomerView : IView
    {
        Customer Customer { get; set; }
        DialogResult ShowDialog();
    }
}
