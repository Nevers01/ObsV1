using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Obs_Basic.Helper;

namespace Obs_Basic
{
    public partial class UserForm : Form
    {
        private readonly ListManager _listManager = new ListManager();

        public UserForm()
        {
            InitializeComponent();
            RefreshAllLists();
        }

        private void RefreshAllLists()
        {
            _listManager.FillUserDiscList(UserDiscs);
            _listManager.FillAnnoList(UserAnno);
        }

        private async void aiSend_btn_Click(object sender, EventArgs e)
        {
            string prompt = aiPrompt_txt.Text.Trim();

            if (string.IsNullOrEmpty(prompt))
            {
                MessageBox.Show("Lütfen bir mesaj yazın.");
                return;
            }

            aiChat_txt.AppendText("Sen: " + prompt + Environment.NewLine);
            aiPrompt_txt.Clear();
            status_lbl.Text = "İşleniyor...";

            AiManager ai = new AiManager();
            string response = await ai.GetAiResponseAsync(prompt);

            aiChat_txt.AppendText("Yapay Zeka: " + response + Environment.NewLine);
            status_lbl.Text = "Yanıt alındı";
        }

        private void userLogout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}