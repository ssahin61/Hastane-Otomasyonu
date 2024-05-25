namespace Hastane_Proje
{
    partial class FrmHastaBilgiDuzenle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgiDuzenle));
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.BtnGuncelle = new System.Windows.Forms.Button();
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
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Cambria", 15F);
			this.txtAd.Location = new System.Drawing.Point(141, 91);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(214, 37);
			this.txtAd.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe Script", 15.2F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(23, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(350, 43);
			this.label7.TabIndex = 33;
			this.label7.Text = "Bilgi Düzenleme Paneli";
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.BackColor = System.Drawing.Color.Gray;
			this.BtnGuncelle.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGuncelle.ForeColor = System.Drawing.Color.Lime;
			this.BtnGuncelle.Location = new System.Drawing.Point(141, 431);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(214, 50);
			this.BtnGuncelle.TabIndex = 7;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = false;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// CmbCinsiyet
			// 
			this.CmbCinsiyet.Font = new System.Drawing.Font("Cambria", 15F);
			this.CmbCinsiyet.FormattingEnabled = true;
			this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
			this.CmbCinsiyet.Location = new System.Drawing.Point(141, 376);
			this.CmbCinsiyet.Name = "CmbCinsiyet";
			this.CmbCinsiyet.Size = new System.Drawing.Size(214, 38);
			this.CmbCinsiyet.TabIndex = 6;
			// 
			// TxtSifre
			// 
			this.TxtSifre.Font = new System.Drawing.Font("Cambria", 15F);
			this.TxtSifre.Location = new System.Drawing.Point(141, 319);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new System.Drawing.Size(214, 37);
			this.TxtSifre.TabIndex = 5;
			// 
			// MskTEL
			// 
			this.MskTEL.Font = new System.Drawing.Font("Cambria", 15F);
			this.MskTEL.Location = new System.Drawing.Point(141, 262);
			this.MskTEL.Mask = "(999) 000-0000";
			this.MskTEL.Name = "MskTEL";
			this.MskTEL.Size = new System.Drawing.Size(214, 37);
			this.MskTEL.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 15F);
			this.label5.Location = new System.Drawing.Point(26, 376);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 30);
			this.label5.TabIndex = 28;
			this.label5.Text = "Cinsiyet:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 15F);
			this.label6.Location = new System.Drawing.Point(62, 319);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 30);
			this.label6.TabIndex = 27;
			this.label6.Text = "Şifre:";
			// 
			// mskTC
			// 
			this.mskTC.Enabled = false;
			this.mskTC.Font = new System.Drawing.Font("Cambria", 15F);
			this.mskTC.Location = new System.Drawing.Point(141, 205);
			this.mskTC.Mask = "00000000000";
			this.mskTC.Name = "mskTC";
			this.mskTC.Size = new System.Drawing.Size(214, 37);
			this.mskTC.TabIndex = 3;
			this.mskTC.ValidatingType = typeof(int);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 15F);
			this.label3.Location = new System.Drawing.Point(32, 263);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 30);
			this.label3.TabIndex = 25;
			this.label3.Text = "Telefon:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 15F);
			this.label4.Location = new System.Drawing.Point(82, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 30);
			this.label4.TabIndex = 24;
			this.label4.Text = "TC:";
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Font = new System.Drawing.Font("Cambria", 15F);
			this.TxtSoyad.Location = new System.Drawing.Point(141, 148);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(214, 37);
			this.TxtSoyad.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 15F);
			this.label2.Location = new System.Drawing.Point(48, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 30);
			this.label2.TabIndex = 22;
			this.label2.Text = "Soyad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 15F);
			this.label1.Location = new System.Drawing.Point(81, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 30);
			this.label1.TabIndex = 21;
			this.label1.Text = "Ad:";
			// 
			// FrmHastaBilgiDuzenle
			// 
			this.AcceptButton = this.BtnGuncelle;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(411, 509);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.BtnGuncelle);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmHastaBilgiDuzenle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hasta Bilgi Düzenle";
			this.Load += new System.EventHandler(this.FrmHastaBilgiDuzenle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnGuncelle;
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