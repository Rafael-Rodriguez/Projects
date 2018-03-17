using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Views
{
    public interface IAddModifyCustomerView : IView
    {
        DialogResult ShowDialog();
    }
}
