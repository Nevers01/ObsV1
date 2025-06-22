namespace Obs_Basic
{
    partial class UserForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userLogout_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.status_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aiSend_btn = new System.Windows.Forms.Button();
            this.aiPrompt_txt = new System.Windows.Forms.TextBox();
            this.aiChat_txt = new System.Windows.Forms.TextBox();
            this.UserDiscs = new System.Windows.Forms.ListView();
            this.UserAnno = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userLogout_btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Anasayfa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userLogout_btn
            // 
            this.userLogout_btn.Location = new System.Drawing.Point(654, 364);
            this.userLogout_btn.Name = "userLogout_btn";
            this.userLogout_btn.Size = new System.Drawing.Size(118, 80);
            this.userLogout_btn.TabIndex = 0;
            this.userLogout_btn.Text = "Çıkış Yap";
            this.userLogout_btn.UseVisualStyleBackColor = true;
            this.userLogout_btn.Click += new System.EventHandler(this.userLogout_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notlarım";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.UserDiscs);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Devamsızlıklarım";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.UserAnno);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(778, 450);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Duyurular";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.status_lbl);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.aiSend_btn);
            this.tabPage5.Controls.Add(this.aiPrompt_txt);
            this.tabPage5.Controls.Add(this.aiChat_txt);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(778, 450);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ai";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(640, 349);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(0, 13);
            this.status_lbl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Durum : ";
            // 
            // aiSend_btn
            // 
            this.aiSend_btn.Location = new System.Drawing.Point(598, 376);
            this.aiSend_btn.Name = "aiSend_btn";
            this.aiSend_btn.Size = new System.Drawing.Size(167, 61);
            this.aiSend_btn.TabIndex = 2;
            this.aiSend_btn.Text = "Gönder";
            this.aiSend_btn.UseVisualStyleBackColor = true;
            this.aiSend_btn.Click += new System.EventHandler(this.aiSend_btn_Click);
            // 
            // aiPrompt_txt
            // 
            this.aiPrompt_txt.Location = new System.Drawing.Point(8, 349);
            this.aiPrompt_txt.Multiline = true;
            this.aiPrompt_txt.Name = "aiPrompt_txt";
            this.aiPrompt_txt.Size = new System.Drawing.Size(561, 88);
            this.aiPrompt_txt.TabIndex = 1;
            // 
            // aiChat_txt
            // 
            this.aiChat_txt.Location = new System.Drawing.Point(8, 6);
            this.aiChat_txt.Multiline = true;
            this.aiChat_txt.Name = "aiChat_txt";
            this.aiChat_txt.ReadOnly = true;
            this.aiChat_txt.Size = new System.Drawing.Size(764, 322);
            this.aiChat_txt.TabIndex = 0;
            // 
            // UserDiscs
            // 
            this.UserDiscs.HideSelection = false;
            this.UserDiscs.Location = new System.Drawing.Point(0, 0);
            this.UserDiscs.Name = "UserDiscs";
            this.UserDiscs.Size = new System.Drawing.Size(778, 450);
            this.UserDiscs.TabIndex = 0;
            this.UserDiscs.UseCompatibleStateImageBehavior = false;
            // 
            // UserAnno
            // 
            this.UserAnno.HideSelection = false;
            this.UserAnno.Location = new System.Drawing.Point(0, 0);
            this.UserAnno.Name = "UserAnno";
            this.UserAnno.Size = new System.Drawing.Size(778, 450);
            this.UserAnno.TabIndex = 0;
            this.UserAnno.UseCompatibleStateImageBehavior = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 472);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.Button aiSend_btn;
        public System.Windows.Forms.TextBox aiPrompt_txt;
        public System.Windows.Forms.TextBox aiChat_txt;
        public System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userLogout_btn;
        private System.Windows.Forms.ListView UserDiscs;
        private System.Windows.Forms.ListView UserAnno;
    }
}