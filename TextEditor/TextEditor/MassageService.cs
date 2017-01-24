using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMessageServis
    {
        void ShowMessage(string message);
        void ShowExclamation(string execlamation);
        void ShowError(string error);

    }
    public class MassageService : IMessageServis
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowExclamation(string execlamation)
        {
            MessageBox.Show(execlamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
