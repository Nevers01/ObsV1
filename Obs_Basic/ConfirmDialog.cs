using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obs_Basic
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog(string mesaj)
        {
            InitializeComponent();
            lblMesaj.Text = mesaj; // Burada label'e yazdırıyorsun
        }

        private void dia_onay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void dia_ret_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}