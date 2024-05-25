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
	public partial class FrmSekreterDetay : Form
	{
		public FrmSekreterDetay()
		{
			InitializeComponent();
		}

		public string TCnumara;
		sqlbaglantisi bgl = new sqlbaglantisi();
		private void FrmSekreterDetay_Load(object sender, EventArgs e)
		{
			LblTC.Text = TCnumara;

			//Ad Soyad çekme
			SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreterler where SekreterTC=@p1", bgl.baglanti());
			komut1.Parameters.AddWithValue("@p1", LblTC.Text);
			SqlDataReader dr1 = komut1.ExecuteReader();
			while (dr1.Read())
			{
				LblAdSoyad.Text = dr1[0].ToString();
			}
			bgl.baglanti().Close();

			//Branşları çekme
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
			DataTable dt1 = new DataTable();
			SqlDataAdapter da1 = new SqlDataAdapter("Select BransID as 'ID', BransAd as 'Branş' from Tbl_Branslar", bgl.baglanti());
			da1.Fill(dt1);
			dataGridView1.DataSource = dt1;

			//Doktorları çekme
			this.dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 10);
			DataTable dt2 = new DataTable();
			SqlDataAdapter da2 = new SqlDataAdapter("select DoktorID as 'ID', DoktorAd + ' ' + DoktorSoyad as 'Doktor', BransAd as 'Branş' from Tbl_Doktorlar inner join Tbl_Branslar on Tbl_Doktorlar.DoktorBrans = Tbl_Branslar.BransID", bgl.baglanti());
			da2.Fill(dt2);
			dataGridView2.DataSource = dt2;

			//Branşları ComboBox'a çekme
			SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				CmbBrans.Items.Add(dr2[0].ToString());
			}
			bgl.baglanti().Close();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			SekreterIslem islem = new SekreterIslem();
			islem.RandevuOlustur(MskTarih.Text, MskSaat.Text, CmbBrans.Text, CmbDoktor.Text, ChkDurum.Checked, MskTC.Text);
		}

		private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
		{
			CmbDoktor.Items.Clear();

			SqlCommand komut3 = new SqlCommand(@"SELECT DoktorAd, DoktorSoyad FROM Tbl_Doktorlar
			INNER JOIN Tbl_Branslar
			ON Tbl_Doktorlar.DoktorBrans = Tbl_Branslar.BransID
			WHERE Tbl_Branslar.BransAd = @p1", bgl.baglanti());
			komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
			SqlDataReader dr3 = komut3.ExecuteReader();
			while (dr3.Read())
			{
				CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
			}
			bgl.baglanti().Close();
		}

		private void BtnOlustur_Click(object sender, EventArgs e)
		{
			SekreterIslem islem = new SekreterIslem();
			islem.DuyuruOlustur(RchDuyuru.Text);
		}

		private void BtnDoktorPaneli_Click(object sender, EventArgs e)
		{
			FrmDoktorPaneli drp = new FrmDoktorPaneli();
			drp.Show();
		}

		private void BtnBranşPaneli_Click(object sender, EventArgs e)
		{
			FrmBransPaneli frb = new FrmBransPaneli();
			frb.Show();
		}

		private void BtnRandevuListesi_Click(object sender, EventArgs e)
		{
			FrmRandevuListesi frl = new FrmRandevuListesi();
			frl.Show();
		}

		private void BtnDuyurular_Click(object sender, EventArgs e)
		{
			FrmDuyurular frd = new FrmDuyurular();
			frd.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
