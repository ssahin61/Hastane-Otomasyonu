namespace Hastane_Proje
{
    partial class FrmSekreterGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
			this.label3 = new System.Windows.Forms.Label();
			this.BtnGirisYap = new System.Windows.Forms.Button();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.MskTC = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(9, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(435, 61);
			this.label3.TabIndex = 9;
			this.label3.Text = "Sekreter Giriş Paneli";
			// 
			// BtnGirisYap
			// 
			this.BtnGirisYap.BackColor = System.Drawing.Color.Gray;
			this.BtnGirisYap.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGirisYap.ForeColor = System.Drawing.Color.White;
			this.BtnGirisYap.Location = new System.Drawing.Point(287, 247);
			this.BtnGirisYap.Name = "BtnGirisYap";
			this.BtnGirisYap.Size = new System.Drawing.Size(152, 51);
			this.BtnGirisYap.TabIndex = 17;
			this.BtnGirisYap.Text = "Giriş Yap";
			this.BtnGirisYap.UseVisualStyleBackColor = false;
			this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
			// 
			// TxtSifre
			// 
			this.TxtSifre.Font = new System.Drawing.Font("Cambria", 16F);
			this.TxtSifre.Location = new System.Drawing.Point(230, 191);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.PasswordChar = '*';
			this.TxtSifre.Size = new System.Drawing.Size(209, 39);
			this.TxtSifre.TabIndex = 16;
			this.TxtSifre.Text = "2111";
			// 
			// MskTC
			// 
			this.MskTC.Font = new System.Drawing.Font("Cambria", 16F);
			this.MskTC.Location = new System.Drawing.Point(230, 131);
			this.MskTC.Mask = "00000000000";
			this.MskTC.Name = "MskTC";
			this.MskTC.Size = new System.Drawing.Size(209, 39);
			this.MskTC.TabIndex = 15;
			this.MskTC.Text = "21111111111";
			this.MskTC.ValidatingType = typeof(int);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(136, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 33);
			this.label2.TabIndex = 14;
			this.label2.Text = "Şifre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(38, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 33);
			this.label1.TabIndex = 13;
			this.label1.Text = "TC Kimlik No:";
			// 
			// FrmSekreterGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(486, 325);
			this.Controls.Add(this.BtnGirisYap);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.MskTC);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmSekreterGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sekreter Girişi";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button BtnGirisYap;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.MaskedTextBox MskTC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}