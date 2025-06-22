namespace Obs_Basic
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.username_txt = new System.Windows.Forms.TextBox();
            this.psswd_txt = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.MainMenu_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(220, 115);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(329, 20);
            this.username_txt.TabIndex = 0;
            // 
            // psswd_txt
            // 
            this.psswd_txt.HideSelection = false;
            this.psswd_txt.Location = new System.Drawing.Point(220, 190);
            this.psswd_txt.Name = "psswd_txt";
            this.psswd_txt.Size = new System.Drawing.Size(329, 20);
            this.psswd_txt.TabIndex = 1;
            this.psswd_txt.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(314, 243);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(133, 56);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // MainMenu_btn
            // 
            this.MainMenu_btn.Location = new System.Drawing.Point(314, 323);
            this.MainMenu_btn.Name = "MainMenu_btn";
            this.MainMenu_btn.Size = new System.Drawing.Size(133, 56);
            this.MainMenu_btn.TabIndex = 5;
            this.MainMenu_btn.Text = "Ana Menü";
            this.MainMenu_btn.UseVisualStyleBackColor = true;
            this.MainMenu_btn.Click += new System.EventHandler(this.MainMenu_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(760, 463);
            this.Controls.Add(this.MainMenu_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.psswd_txt);
            this.Controls.Add(this.username_txt);
            this.Name = "LoginForm";
            this.Text = "ŞAH Öğrenci Bilgi Sistemi | Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox username_txt;
        public System.Windows.Forms.TextBox psswd_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button MainMenu_btn;
    }
}

