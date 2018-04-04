using System.Windows.Forms;

namespace Chapter21.CustomerTxtAndBinary.Presentation.Views
{
    public interface IImportCustomersView : IView
    {
        DataGridView DataGrid { get; }
    }
}
