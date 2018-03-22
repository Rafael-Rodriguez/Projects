using Chapter20.CustomerMaintenance.Models;
using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Presentation.Views
{
    public interface IModifyCustomerView : IView
    {
        Customer Customer { get; set; }
        DialogResult ShowDialog(Customer customer);
    }
}
