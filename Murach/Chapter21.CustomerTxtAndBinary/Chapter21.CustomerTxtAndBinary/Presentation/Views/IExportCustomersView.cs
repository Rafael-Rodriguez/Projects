using System.Windows.Forms;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Views
{
    public interface IExportCustomersView : IView
    {
        DialogResult ShowDialog();
    }
}
