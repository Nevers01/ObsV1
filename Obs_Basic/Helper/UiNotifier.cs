using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbHelper;
using System.Windows.Forms;

namespace Obs_Basic.Helper
{
    public static class UiNotifier
    {
        public static void ShowResult(OperationResult result, Action onSuccess)
        {
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message);
                onSuccess?.Invoke();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        public static void ShowSuccess(string message) => MessageBox.Show(message, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void ShowError(string message) => MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static bool Confirm(string message) =>
            MessageBox.Show(message, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }
}