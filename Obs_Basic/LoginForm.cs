using DbHelper.Services;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DbHelper.Login lg = new DbHelper.Login();
            var result = lg.LoginControl(username_txt.Text, psswd_txt.Text);

            if (result.IsSuccess)
            {
                MessageBox.Show(result.IsAdmin ? "Hoşgeldin " + username_txt.Text + " Giriş başarılı!" : "Hoşgeldin " + username_txt.Text + " Giriş başarılı!");

                UserSession.UserId = result.UserId;

                // Örnek yönlendirme:
                if (result.IsAdmin)
                {
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Close();
                }
                else
                {
                    UserForm panel = new UserForm();
                    panel.Show();
                    this.Close();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void MainMenu_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            MainForm MF = new MainForm();
            MF.Show();
        }

    }
}