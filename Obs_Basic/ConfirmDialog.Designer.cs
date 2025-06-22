namespace Obs_Basic
{
    partial class ConfirmDialog
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
            this.dia_onay = new System.Windows.Forms.Button();
            this.dia_ret = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dia_onay
            // 
            this.dia_onay.Location = new System.Drawing.Point(12, 86);
            this.dia_onay.Name = "dia_onay";
            this.dia_onay.Size = new System.Drawing.Size(103, 38);
            this.dia_onay.TabIndex = 0;
            this.dia_onay.Text = "EVET";
            this.dia_onay.UseVisualStyleBackColor = true;
            this.dia_onay.Click += new System.EventHandler(this.dia_onay_Click);
            // 
            // dia_ret
            // 
            this.dia_ret.Location = new System.Drawing.Point(253, 86);
            this.dia_ret.Name = "dia_ret";
            this.dia_ret.Size = new System.Drawing.Size(103, 38);
            this.dia_ret.TabIndex = 1;
            this.dia_ret.Text = "HAYIR";
            this.dia_ret.UseVisualStyleBackColor = true;
            this.dia_ret.Click += new System.EventHandler(this.dia_ret_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(64, 37);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 2;
            // 
            // ConfirmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 136);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.dia_ret);
            this.Controls.Add(this.dia_onay);
            this.Name = "ConfirmDialog";
            this.Text = "ConfirmDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dia_onay;
        private System.Windows.Forms.Button dia_ret;
        private System.Windows.Forms.Label lblMesaj;
    }
}