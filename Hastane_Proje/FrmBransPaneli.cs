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

namespace Hastane_Proje
{
	public partial class FrmBransPaneli : Form
	{
		public FrmBransPaneli()
		{
			InitializeComponent();
		}

		sqlbaglantisi bgl = new sqlbaglantisi();

		private void FrmBrans_Load(object sender, EventArgs e)
		{
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 11);
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar ", bgl.baglanti());
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		private void BtnEkle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)", bgl.baglanti());
			komut.Parameters.AddWithValue("@b1", TxtAd.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Branş Başarıyla Eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Branslar WHERE BransID = @b1", bgl.baglanti());
			cmd.Parameters.AddWithValue("@b1", txtID.Text);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Branş Başarıyla Silindi veya Doktorların Branşı NULL Olarak Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where BransID=@p2", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", TxtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Branş Başarıyla Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnDoktorSayisi_Click(object sender, EventArgs e)
		{
			int bransID = Convert.ToInt32(txtID.Text);
			string bransAd = TxtAd.Text;
			using (SqlCommand command = new SqlCommand("SELECT dbo.getBransaAitDoktorSayisi(@bransID)", bgl.baglanti()))
			{
				command.Parameters.AddWithValue("@bransID", bransID);
				try
				{
					int doktorSayisi = (int)command.ExecuteScalar();
					MessageBox.Show(bransAd + " branşına ait doktor sayısı: " + doktorSayisi.ToString(), "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hata oluştu: " + ex.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
