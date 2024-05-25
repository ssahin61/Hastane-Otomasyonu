namespace Hastane_Proje
{
    partial class FrmBransPaneli
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBransPaneli));
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.BtnGuncelle = new System.Windows.Forms.Button();
			this.BtnEkle = new System.Windows.Forms.Button();
			this.BtnSil = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnDoktorSayisi = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// TxtAd
			// 
			this.TxtAd.Font = new System.Drawing.Font("Cambria", 15F);
			this.TxtAd.Location = new System.Drawing.Point(143, 85);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(214, 37);
			this.TxtAd.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(378, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(583, 319);
			this.dataGridView1.TabIndex = 85;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.BackColor = System.Drawing.Color.Gray;
			this.BtnGuncelle.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGuncelle.ForeColor = System.Drawing.Color.LawnGreen;
			this.BtnGuncelle.Location = new System.Drawing.Point(144, 194);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(213, 51);
			this.BtnGuncelle.TabIndex = 5;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.UseVisualStyleBackColor = false;
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnEkle
			// 
			this.BtnEkle.BackColor = System.Drawing.Color.Gray;
			this.BtnEkle.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnEkle.ForeColor = System.Drawing.SystemColors.Control;
			this.BtnEkle.Location = new System.Drawing.Point(257, 137);
			this.BtnEkle.Name = "BtnEkle";
			this.BtnEkle.Size = new System.Drawing.Size(100, 51);
			this.BtnEkle.TabIndex = 3;
			this.BtnEkle.Text = "Ekle";
			this.BtnEkle.UseVisualStyleBackColor = false;
			this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.BackColor = System.Drawing.Color.Gray;
			this.BtnSil.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnSil.ForeColor = System.Drawing.Color.DarkRed;
			this.BtnSil.Location = new System.Drawing.Point(143, 137);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(100, 51);
			this.BtnSil.TabIndex = 4;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = false;
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// txtID
			// 
			this.txtID.Enabled = false;
			this.txtID.Font = new System.Drawing.Font("Cambria", 15F);
			this.txtID.Location = new System.Drawing.Point(143, 37);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(214, 37);
			this.txtID.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 15F);
			this.label5.Location = new System.Drawing.Point(14, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 30);
			this.label5.TabIndex = 73;
			this.label5.Text = "Branş Ad:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 15F);
			this.label6.Location = new System.Drawing.Point(22, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 30);
			this.label6.TabIndex = 74;
			this.label6.Text = "Branş ID:";
			// 
			// btnDoktorSayisi
			// 
			this.btnDoktorSayisi.BackColor = System.Drawing.Color.Gray;
			this.btnDoktorSayisi.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDoktorSayisi.ForeColor = System.Drawing.Color.Aquamarine;
			this.btnDoktorSayisi.Location = new System.Drawing.Point(145, 251);
			this.btnDoktorSayisi.Name = "btnDoktorSayisi";
			this.btnDoktorSayisi.Size = new System.Drawing.Size(213, 86);
			this.btnDoktorSayisi.TabIndex = 86;
			this.btnDoktorSayisi.Text = "Doktor Sayısını Getir";
			this.btnDoktorSayisi.UseVisualStyleBackColor = false;
			this.btnDoktorSayisi.Click += new System.EventHandler(this.btnDoktorSayisi_Click);
			// 
			// FrmBransPaneli
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(972, 362);
			this.Controls.Add(this.btnDoktorSayisi);
			this.Controls.Add(this.TxtAd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.BtnGuncelle);
			this.Controls.Add(this.BtnEkle);
			this.Controls.Add(this.BtnSil);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmBransPaneli";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Branş Paneli";
			this.Load += new System.EventHandler(this.FrmBrans_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnDoktorSayisi;
	}
}