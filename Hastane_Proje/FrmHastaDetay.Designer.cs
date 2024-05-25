namespace Hastane_Proje
{
    partial class FrmHastaDetay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.LblAdSoyad = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LblTC = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.TxtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LnkBilgiDuzenle = new System.Windows.Forms.LinkLabel();
			this.BtnRandevuAl = new System.Windows.Forms.Button();
			this.RchSikayet = new System.Windows.Forms.RichTextBox();
			this.CmbDoktor = new System.Windows.Forms.ComboBox();
			this.CmbBrans = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.LblAdSoyad);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.LblTC);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(373, 142);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hasta Bilgi";
			// 
			// LblAdSoyad
			// 
			this.LblAdSoyad.AutoSize = true;
			this.LblAdSoyad.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblAdSoyad.Location = new System.Drawing.Point(166, 86);
			this.LblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblAdSoyad.Name = "LblAdSoyad";
			this.LblAdSoyad.Size = new System.Drawing.Size(95, 26);
			this.LblAdSoyad.TabIndex = 13;
			this.LblAdSoyad.Text = "Null Null";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(55, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 26);
			this.label2.TabIndex = 12;
			this.label2.Text = "Ad Soyad:";
			// 
			// LblTC
			// 
			this.LblTC.AutoSize = true;
			this.LblTC.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblTC.Location = new System.Drawing.Point(166, 44);
			this.LblTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblTC.Name = "LblTC";
			this.LblTC.Size = new System.Drawing.Size(144, 26);
			this.LblTC.TabIndex = 11;
			this.LblTC.Text = "00000000000";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(19, 44);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 26);
			this.label4.TabIndex = 10;
			this.label4.Text = "TC Kimlik No:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.TxtID);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.LnkBilgiDuzenle);
			this.groupBox2.Controls.Add(this.BtnRandevuAl);
			this.groupBox2.Controls.Add(this.RchSikayet);
			this.groupBox2.Controls.Add(this.CmbDoktor);
			this.groupBox2.Controls.Add(this.CmbBrans);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(12, 161);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(373, 497);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Randevu Paneli";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Gray;
			this.button2.Font = new System.Drawing.Font("Cambria", 15F);
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(21, 431);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 55);
			this.button2.TabIndex = 6;
			this.button2.Text = "Duyurular";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gray;
			this.button1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.DarkRed;
			this.button1.Location = new System.Drawing.Point(192, 431);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 55);
			this.button1.TabIndex = 22;
			this.button1.Text = "Çıkış Yap";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TxtID
			// 
			this.TxtID.Enabled = false;
			this.TxtID.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TxtID.Location = new System.Drawing.Point(127, 36);
			this.TxtID.Margin = new System.Windows.Forms.Padding(2);
			this.TxtID.Name = "TxtID";
			this.TxtID.Size = new System.Drawing.Size(225, 37);
			this.TxtID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(69, 40);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 30);
			this.label1.TabIndex = 21;
			this.label1.Text = "ID:";
			// 
			// LnkBilgiDuzenle
			// 
			this.LnkBilgiDuzenle.AutoSize = true;
			this.LnkBilgiDuzenle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LnkBilgiDuzenle.Location = new System.Drawing.Point(15, 392);
			this.LnkBilgiDuzenle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LnkBilgiDuzenle.Name = "LnkBilgiDuzenle";
			this.LnkBilgiDuzenle.Size = new System.Drawing.Size(93, 17);
			this.LnkBilgiDuzenle.TabIndex = 20;
			this.LnkBilgiDuzenle.TabStop = true;
			this.LnkBilgiDuzenle.Text = "Bilgi Düzenle";
			this.LnkBilgiDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkBilgiDuzenle_LinkClicked);
			// 
			// BtnRandevuAl
			// 
			this.BtnRandevuAl.BackColor = System.Drawing.Color.Gray;
			this.BtnRandevuAl.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnRandevuAl.ForeColor = System.Drawing.Color.Lime;
			this.BtnRandevuAl.Location = new System.Drawing.Point(127, 370);
			this.BtnRandevuAl.Margin = new System.Windows.Forms.Padding(2);
			this.BtnRandevuAl.Name = "BtnRandevuAl";
			this.BtnRandevuAl.Size = new System.Drawing.Size(225, 54);
			this.BtnRandevuAl.TabIndex = 19;
			this.BtnRandevuAl.Text = "Randevu Al";
			this.BtnRandevuAl.UseVisualStyleBackColor = false;
			this.BtnRandevuAl.Click += new System.EventHandler(this.BtnRandevuAl_Click);
			// 
			// RchSikayet
			// 
			this.RchSikayet.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.RchSikayet.Location = new System.Drawing.Point(127, 189);
			this.RchSikayet.Margin = new System.Windows.Forms.Padding(2);
			this.RchSikayet.Name = "RchSikayet";
			this.RchSikayet.Size = new System.Drawing.Size(225, 170);
			this.RchSikayet.TabIndex = 4;
			this.RchSikayet.Text = "";
			// 
			// CmbDoktor
			// 
			this.CmbDoktor.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.CmbDoktor.FormattingEnabled = true;
			this.CmbDoktor.Location = new System.Drawing.Point(127, 138);
			this.CmbDoktor.Margin = new System.Windows.Forms.Padding(2);
			this.CmbDoktor.Name = "CmbDoktor";
			this.CmbDoktor.Size = new System.Drawing.Size(225, 38);
			this.CmbDoktor.TabIndex = 3;
			this.CmbDoktor.SelectedIndexChanged += new System.EventHandler(this.CmbDoktor_SelectedIndexChanged);
			// 
			// CmbBrans
			// 
			this.CmbBrans.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.CmbBrans.FormattingEnabled = true;
			this.CmbBrans.Location = new System.Drawing.Point(127, 86);
			this.CmbBrans.Margin = new System.Windows.Forms.Padding(2);
			this.CmbBrans.Name = "CmbBrans";
			this.CmbBrans.Size = new System.Drawing.Size(225, 38);
			this.CmbBrans.TabIndex = 2;
			this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(20, 139);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 30);
			this.label5.TabIndex = 14;
			this.label5.Text = "Doktor:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(17, 192);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 30);
			this.label7.TabIndex = 15;
			this.label7.Text = "Şikayet:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(32, 89);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 30);
			this.label6.TabIndex = 14;
			this.label6.Text = "Branş:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Font = new System.Drawing.Font("Book Antiqua", 9.8F, System.Drawing.FontStyle.Bold);
			this.groupBox3.Location = new System.Drawing.Point(400, 12);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(918, 325);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Randevu Geçmişiniz";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(2, 22);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(914, 301);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGridView2);
			this.groupBox4.Font = new System.Drawing.Font("Book Antiqua", 9.8F, System.Drawing.FontStyle.Bold);
			this.groupBox4.Location = new System.Drawing.Point(400, 345);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox4.Size = new System.Drawing.Size(916, 313);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Doktorun Aktif Randevuları";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(2, 22);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(912, 289);
			this.dataGridView2.TabIndex = 0;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
			// 
			// FrmHastaDetay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1329, 668);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.Name = "FrmHastaDetay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hasta Detay";
			this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RchSikayet;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnRandevuAl;
        private System.Windows.Forms.LinkLabel LnkBilgiDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ComboBox CmbBrans;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}