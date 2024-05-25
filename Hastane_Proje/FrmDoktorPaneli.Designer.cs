namespace Hastane_Proje
{
    partial class FrmDoktorPaneli
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
			this.CmbBrans = new System.Windows.Forms.ComboBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.MskTC = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnSil = new System.Windows.Forms.Button();
			this.BtnEkle = new System.Windows.Forms.Button();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRandevuSayisi = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// CmbBrans
			// 
			this.CmbBrans.Font = new System.Drawing.Font("Cambria", 15F);
			this.CmbBrans.FormattingEnabled = true;
			this.CmbBrans.Location = new System.Drawing.Point(123, 181);
			this.CmbBrans.Name = "CmbBrans";
			this.CmbBrans.Size = new System.Drawing.Size(214, 38);
			this.CmbBrans.TabIndex = 3;
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Cambria", 15F);
			this.txtAd.Location = new System.Drawing.Point(123, 75);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(214, 37);
			this.txtAd.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Cambria", 15F);
			this.label8.Location = new System.Drawing.Point(34, 182);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 30);
			this.label8.TabIndex = 59;
			this.label8.Text = "Branş:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 15F);
			this.label5.Location = new System.Drawing.Point(33, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 30);
			this.label5.TabIndex = 56;
			this.label5.Text = "Soyad:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 15F);
			this.label6.Location = new System.Drawing.Point(66, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 30);
			this.label6.TabIndex = 57;
			this.label6.Text = "Ad:";
			// 
			// MskTC
			// 
			this.MskTC.Font = new System.Drawing.Font("Cambria", 15F);
			this.MskTC.Location = new System.Drawing.Point(123, 235);
			this.MskTC.Mask = "00000000000";
			this.MskTC.Name = "MskTC";
			this.MskTC.Size = new System.Drawing.Size(214, 37);
			this.MskTC.TabIndex = 4;
			this.MskTC.ValidatingType = typeof(int);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 15F);
			this.label3.Location = new System.Drawing.Point(67, 238);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 30);
			this.label3.TabIndex = 64;
			this.label3.Text = "TC:";
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Cambria", 15F);
			this.txtSifre.Location = new System.Drawing.Point(123, 288);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.PasswordChar = '*';
			this.txtSifre.Size = new System.Drawing.Size(214, 37);
			this.txtSifre.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 15F);
			this.label1.Location = new System.Drawing.Point(47, 289);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 30);
			this.label1.TabIndex = 66;
			this.label1.Text = "Şifre:";
			// 
			// BtnSil
			// 
			this.BtnSil.BackColor = System.Drawing.Color.Gray;
			this.BtnSil.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnSil.ForeColor = System.Drawing.Color.DarkRed;
			this.BtnSil.Location = new System.Drawing.Point(123, 388);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(100, 51);
			this.BtnSil.TabIndex = 68;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = false;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnEkle
			// 
			this.BtnEkle.BackColor = System.Drawing.Color.Gray;
			this.BtnEkle.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnEkle.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnEkle.Location = new System.Drawing.Point(237, 388);
			this.BtnEkle.Name = "BtnEkle";
			this.BtnEkle.Size = new System.Drawing.Size(100, 51);
			this.BtnEkle.TabIndex = 69;
			this.BtnEkle.Text = "Ekle";
			this.BtnEkle.UseVisualStyleBackColor = false;
			this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.BackColor = System.Drawing.Color.Gray;
			this.BtnGuncelle.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGuncelle.ForeColor = System.Drawing.Color.LawnGreen;
			this.BtnGuncelle.Location = new System.Drawing.Point(123, 445);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(214, 51);
			this.BtnGuncelle.TabIndex = 70;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = false;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.NullValue = "NULL";
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Location = new System.Drawing.Point(356, 17);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1065, 583);
			this.dataGridView1.TabIndex = 71;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// txtSoyad
			// 
			this.txtSoyad.Font = new System.Drawing.Font("Cambria", 15F);
			this.txtSoyad.Location = new System.Drawing.Point(123, 126);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(214, 37);
			this.txtSoyad.TabIndex = 2;
			// 
			// txtID
			// 
			this.txtID.Enabled = false;
			this.txtID.Font = new System.Drawing.Font("Cambria", 15F);
			this.txtID.Location = new System.Drawing.Point(123, 26);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(214, 37);
			this.txtID.TabIndex = 72;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 15F);
			this.label2.Location = new System.Drawing.Point(71, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 30);
			this.label2.TabIndex = 73;
			this.label2.Text = "ID:";
			// 
			// btnRandevuSayisi
			// 
			this.btnRandevuSayisi.BackColor = System.Drawing.Color.Gray;
			this.btnRandevuSayisi.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRandevuSayisi.ForeColor = System.Drawing.Color.Aquamarine;
			this.btnRandevuSayisi.Location = new System.Drawing.Point(123, 503);
			this.btnRandevuSayisi.Name = "btnRandevuSayisi";
			this.btnRandevuSayisi.Size = new System.Drawing.Size(214, 86);
			this.btnRandevuSayisi.TabIndex = 74;
			this.btnRandevuSayisi.Text = "Aktif Randevu Sayısını Getir";
			this.btnRandevuSayisi.UseVisualStyleBackColor = false;
			this.btnRandevuSayisi.Click += new System.EventHandler(this.btnRandevuSayisi_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 15F);
			this.label4.Location = new System.Drawing.Point(11, 339);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 30);
			this.label4.TabIndex = 76;
			this.label4.Text = "Cinsiyet:";
			// 
			// cmbCinsiyet
			// 
			this.cmbCinsiyet.Font = new System.Drawing.Font("Cambria", 15F);
			this.cmbCinsiyet.FormattingEnabled = true;
			this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
			this.cmbCinsiyet.Location = new System.Drawing.Point(123, 338);
			this.cmbCinsiyet.Name = "cmbCinsiyet";
			this.cmbCinsiyet.Size = new System.Drawing.Size(214, 38);
			this.cmbCinsiyet.TabIndex = 77;
			// 
			// FrmDoktorPaneli
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1433, 613);
			this.Controls.Add(this.cmbCinsiyet);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnRandevuSayisi);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.BtnGuncelle);
			this.Controls.Add(this.BtnEkle);
			this.Controls.Add(this.BtnSil);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MskTC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CmbBrans);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmDoktorPaneli";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doktor Paneli";
			this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRandevuSayisi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbCinsiyet;
	}
}