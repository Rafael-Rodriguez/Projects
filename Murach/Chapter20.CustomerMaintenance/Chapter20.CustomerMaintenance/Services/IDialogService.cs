using System.Windows.Forms;

namespace Chapter20.CustomerMaintenance.Services
{
    public interface IDialogService : IService
    {
        DialogResult ShowMessageBox(string text);

        DialogResult ShowMessageBox(string text, string caption);

        DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons);

        DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
    }
}
