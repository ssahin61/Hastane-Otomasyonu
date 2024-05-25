namespace Hastane_Proje
{
    partial class FrmDoktorBilgiDuzenle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.mskTC = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CmbBrans = new System.Windows.Forms.ComboBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
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
			this.label7.Location = new System.Drawing.Point(32, 19);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(350, 43);
			this.label7.TabIndex = 47;
			this.label7.Text = "Bilgi Düzenleme Paneli";
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.BackColor = System.Drawing.Color.Gray;
			this.BtnGuncelle.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGuncelle.ForeColor = System.Drawing.Color.Lime;
			this.BtnGuncelle.Location = new System.Drawing.Point(140, 373);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(214, 50);
			this.BtnGuncelle.TabIndex = 6;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = false;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 15F);
			this.label4.Location = new System.Drawing.Point(82, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 30);
			this.label4.TabIndex = 38;
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
			this.label2.Location = new System.Drawing.Point(48, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 30);
			this.label2.TabIndex = 36;
			this.label2.Text = "Soyad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 15F);
			this.label1.Location = new System.Drawing.Point(81, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 30);
			this.label1.TabIndex = 35;
			this.label1.Text = "Ad:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 15F);
			this.label3.Location = new System.Drawing.Point(49, 262);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 30);
			this.label3.TabIndex = 49;
			this.label3.Text = "Branş:";
			// 
			// CmbBrans
			// 
			this.CmbBrans.Font = new System.Drawing.Font("Cambria", 15F);
			this.CmbBrans.FormattingEnabled = true;
			this.CmbBrans.Location = new System.Drawing.Point(141, 262);
			this.CmbBrans.Name = "CmbBrans";
			this.CmbBrans.Size = new System.Drawing.Size(214, 38);
			this.CmbBrans.TabIndex = 4;
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Cambria", 15F);
			this.txtSifre.Location = new System.Drawing.Point(141, 319);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(214, 37);
			this.txtSifre.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 15F);
			this.label5.Location = new System.Drawing.Point(62, 319);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 30);
			this.label5.TabIndex = 51;
			this.label5.Text = "Şifre:";
			// 
			// FrmDoktorBilgiDuzenle
			// 
			this.AcceptButton = this.BtnGuncelle;
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(406, 452);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CmbBrans);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.BtnGuncelle);
			this.Controls.Add(this.mskTC);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TxtSoyad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmDoktorBilgiDuzenle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doktor Bilgi Düzenleme";
			this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label5;
    }
}