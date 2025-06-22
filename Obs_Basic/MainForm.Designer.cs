namespace Obs_Basic
{
    partial class MainForm
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
        private void InitializeComponent()
        {
            this.MainLogin_btn = new System.Windows.Forms.Button();
            this.Hakkimizda_btn = new System.Windows.Forms.Button();
            this.AppClose_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainLogin_btn
            // 
            this.MainLogin_btn.Location = new System.Drawing.Point(97, 46);
            this.MainLogin_btn.Name = "MainLogin_btn";
            this.MainLogin_btn.Size = new System.Drawing.Size(129, 65);
            this.MainLogin_btn.TabIndex = 0;
            this.MainLogin_btn.Text = "Giriş Yap";
            this.MainLogin_btn.UseVisualStyleBackColor = true;
            this.MainLogin_btn.Click += new System.EventHandler(this.MainLogin_btn_Click);
            // 
            // Hakkimizda_btn
            // 
            this.Hakkimizda_btn.Location = new System.Drawing.Point(379, 46);
            this.Hakkimizda_btn.Name = "Hakkimizda_btn";
            this.Hakkimizda_btn.Size = new System.Drawing.Size(129, 65);
            this.Hakkimizda_btn.TabIndex = 1;
            this.Hakkimizda_btn.Text = "Hakkımızda";
            this.Hakkimizda_btn.UseVisualStyleBackColor = true;
            // 
            // AppClose_btn
            // 
            this.AppClose_btn.Location = new System.Drawing.Point(97, 159);
            this.AppClose_btn.Name = "AppClose_btn";
            this.AppClose_btn.Size = new System.Drawing.Size(129, 65);
            this.AppClose_btn.TabIndex = 2;
            this.AppClose_btn.Text = "Uygulamayı Kapat";
            this.AppClose_btn.UseVisualStyleBackColor = true;
            this.AppClose_btn.Click += new System.EventHandler(this.AppClose_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ŞAH Öğrenci Bilgi Sistemleri";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppClose_btn);
            this.Controls.Add(this.Hakkimizda_btn);
            this.Controls.Add(this.MainLogin_btn);
            this.Name = "MainForm";
            this.Text = "ŞAH OBS | Ana Menü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainLogin_btn;
        private System.Windows.Forms.Button Hakkimizda_btn;
        private System.Windows.Forms.Button AppClose_btn;
        private System.Windows.Forms.Label label1;
    }
}