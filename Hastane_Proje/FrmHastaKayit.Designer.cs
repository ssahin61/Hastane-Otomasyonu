namespace Hastane_Proje
{
    partial class FrmHastaKayit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
			this.label7 = new System.Windows.Forms.Label();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.BtnKayıtOl = new System.Windows.Forms.Button();
			this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.MskTEL = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mskTC = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe Script", 21.2F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(32, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(384, 60);
			this.label7.TabIndex = 19;
			this.label7.Text = "Hasta Kayıt Paneli";
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Cambria", 15F);
			this.txtAd.Location = new System.Drawing.Point(173, 97);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(214, 37);
			this.txtAd.TabIndex = 29;
			// 
			// BtnKayıtOl
			// 
			this.BtnKayıtOl.BackColor = System.Drawing.Color.Gray;
			this.BtnKayıtOl.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKayıtOl.ForeColor = System.Drawing.Color.Lime;
			this.BtnKayıtOl.Location = new System.Drawing.Point(173, 437);
			this.BtnKayıtOl.Name = "BtnKayıtOl";
			this.BtnKayıtOl.Size = new System.Drawing.Size(214, 50);
			this.BtnKayıtOl.TabIndex = 35;
			this.BtnKayıtOl.Text = "Kayıt Ol";
			this.BtnKayıtOl.UseVisualStyleBackColor = false;
			this.BtnKayıtOl.Click += new System.EventHandler(this.BtnKayıtOl_Click);
			// 
			// CmbCinsiyet
			// 
			this.CmbCinsiyet.Font = new System.Drawing.Font("Cambria", 15F);
			this.CmbCinsiyet.FormattingEnabled = true;
			this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
			this.CmbCinsiyet.Location = new System.Drawing.Point(173, 382);
			this.CmbCinsiyet.Name = "CmbCinsiyet";
			this.CmbCinsiyet.Size = new System.Drawing.Size(214, 38);
			this.CmbCinsiyet.TabIndex = 34;
			// 
			// TxtSifre
			// 
			this.TxtSifre.Font = new System.Drawing.Font("Cambria", 15F);
			this.TxtSifre.Location = new System.Drawing.Point(173, 325);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.PasswordChar = '*';
			this.TxtSifre.Size = new System.Drawing.Size(214, 37);
			this.TxtSifre.TabIndex = 33;
			// 
			// MskTEL
			// 
			this.MskTEL.Font = new System.Drawing.Font("Cambria", 15F);
			this.MskTEL.Location = new System.Drawing.Point(173, 268);
			this.MskTEL.Mask = "(999) 000-0000";
			this.MskTEL.Name = "MskTEL";
			this.MskTEL.Size = new System.Drawing.Size(214, 37);
			this.MskTEL.TabIndex = 32;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 15F);
			this.label5.Location = new System.Drawing.Point(58, 382);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 30);
			this.label5.TabIndex = 41;
			this.label5.Text = "Cinsiyet:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 15F);
			this.label6.Location = new System.Drawing.Point(94, 325);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 30);
			this.label6.TabIndex = 40;
			this.label6.Text = "Şifre:";
			// 
			// mskTC
			// 
			this.mskTC.Font = new System.Drawing.Font("Cambria", 15F);
			this.mskTC.Location = new System.Drawing.Point(173, 211);
			this.mskTC.Mask = "00000000000";
			this.mskTC.Name = "mskTC";
			this.mskTC.Size = new System.Drawing.Size(214, 37);
			this.mskTC.TabIndex = 31;
			this.mskTC.ValidatingType = typeof(int);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 15F);
			this.label3.Location = new System.Drawing.Point(64, 269);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 30);
			this.label3.TabIndex = 39;
			this.label3.Text = "Telefon:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 15F);
			this.label4.Location = new System.Drawing.Point(114, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 30);
			this.label4.TabIndex = 38;
			this.label4.Text = "TC:";
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Font = new System.Drawing.Font("Cambria", 15F);
			this.TxtSoyad.Location = new System.Drawing.Point(173, 154);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(214, 37);
			this.TxtSoyad.TabIndex = 30;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 15F);
			this.label2.Location = new System.Drawing.Point(80, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 30);
			this.label2.TabIndex = 37;
			this.label2.Text = "Soyad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 15F);
			this.label1.Location = new System.Drawing.Point(113, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 30);
			this.label1.TabIndex = 36;
			this.label1.Text = "Ad:";
			// 
			// FrmHastaKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(460, 527);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.BtnKayıtOl);
			this.Controls.Add(this.CmbCinsiyet);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.MskTEL);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.mskTC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TxtSoyad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmHastaKayit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hasta Kayıt";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Button BtnKayıtOl;
		private System.Windows.Forms.ComboBox CmbCinsiyet;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.MaskedTextBox MskTEL;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox mskTC;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}