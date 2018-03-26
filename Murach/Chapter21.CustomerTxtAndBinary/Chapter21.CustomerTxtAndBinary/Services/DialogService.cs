using System.Windows.Forms;

namespace Chapter21.CustomerTxtAndBinary.Services
{
    public sealed class DialogService : IDialogService
    {
        public DialogResult ShowMessageBox(string text)
        {
            return MessageBox.Show(text);
        }

        public DialogResult ShowMessageBox(string text, string caption)
        {
            return MessageBox.Show(text, caption);
        }

        public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons)
        {
            return MessageBox.Show(text, caption, buttons);
        }

        public DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(text, caption, buttons, icon);
        }
    }
}
