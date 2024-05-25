using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Hastane_Proje
{
	public partial class FrmDoktorPaneli : Form
	{
		public FrmDoktorPaneli()
		{
			InitializeComponent();
		}

		sqlbaglantisi bgl = new sqlbaglantisi();
		private void FrmDoktorPaneli_Load(object sender, EventArgs e)
		{
			//dataGridView1.DefaultCellStyle.NullValue = "NULL";
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
			DataTable dt1 = new DataTable();
			SqlDataAdapter da1 = new SqlDataAdapter("Select DoktorID, DoktorAd, DoktorSoyad, BransAd, DoktorTC, DoktorSifre, DoktorCinsiyet from Tbl_Doktorlar left join Tbl_Branslar on Tbl_Doktorlar.DoktorBrans = Tbl_Branslar.BransID", bgl.baglanti());
			da1.Fill(dt1);
			dataGridView1.DataSource = dt1;

			//Branşları ComboBox'a çekme
			SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				CmbBrans.Items.Add(dr2[0].ToString());
			}
			bgl.baglanti().Close();

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			txtID.Text = dataGridView1.Rows[secilen].Cells["DoktorID"].Value.ToString();
			txtAd.Text = dataGridView1.Rows[secilen].Cells["DoktorAd"].Value.ToString();
			txtSoyad.Text = dataGridView1.Rows[secilen].Cells["DoktorSoyad"].Value.ToString();
			CmbBrans.Text = dataGridView1.Rows[secilen].Cells["BransAd"].Value.ToString();
			MskTC.Text = dataGridView1.Rows[secilen].Cells["DoktorTC"].Value.ToString();
			txtSifre.Text = dataGridView1.Rows[secilen].Cells["DoktorSifre"].Value.ToString();
			cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells["DoktorCinsiyet"].Value.ToString();
		}

		private void BtnEkle_Click(object sender, EventArgs e)
		{
			DoktorIslem islem = new DoktorIslem();
			islem.DoktorEkle(txtAd.Text, txtSoyad.Text, CmbBrans.Text, MskTC.Text, txtSifre.Text, cmbCinsiyet.Text);
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DoktorIslem islem = new DoktorIslem();
			islem.DoktorSil(MskTC.Text);
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			DoktorIslem islem = new DoktorIslem();
			islem.DoktorGuncelle(txtAd.Text, txtSoyad.Text, CmbBrans.Text, MskTC.Text, txtSifre.Text, Convert.ToInt32(txtID.Text));
		}

		private void btnRandevuSayisi_Click(object sender, EventArgs e)
		{
			int doktorID = Convert.ToInt32(txtID.Text);
			string doktorAd = txtAd.Text;
			string doktorSoyad = txtSoyad.Text;
			using (SqlCommand command = new SqlCommand("SELECT dbo.getDoktorIcinAktifRandevuSayisi(@doktorID)", bgl.baglanti()))
			{
				command.Parameters.AddWithValue("@doktorID", doktorID);
				try
				{
					int aktifRandevuSayisi = (int)command.ExecuteScalar();
					MessageBox.Show(doktorAd + " " + doktorSoyad + " adlı doktorun aktif randevu sayısı: " + aktifRandevuSayisi.ToString(), "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hata oluştu: " + ex.Message);
				}
			}
		}
	}
}

