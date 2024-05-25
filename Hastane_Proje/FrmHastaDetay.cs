using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
	public partial class FrmHastaDetay : Form
	{
		public FrmHastaDetay()
		{
			InitializeComponent();
		}

		public string tc;
		public string hastaid;
		sqlbaglantisi bgl = new sqlbaglantisi();
		private void FrmHastaDetay_Load(object sender, EventArgs e)
		{
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
			this.dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 10);

			LblTC.Text = tc;

			//Ad Soyad Çekme
			SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar Where HastaTC=@p1", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", LblTC.Text);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				LblAdSoyad.Text = dr[0] + " " + dr[1];
			}
			bgl.baglanti().Close();

			DataTable dt = new DataTable();
			using (SqlConnection baglanti = bgl.baglanti())
			{
				using (SqlCommand command = new SqlCommand("GetRandevuByTC", baglanti)) //procedure
				{
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@tc", tc);

					SqlDataAdapter da = new SqlDataAdapter(command);
					da.Fill(dt);
				}
			}
			dataGridView1.DataSource = dt;

			//Branşları Çekme
			SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				CmbBrans.Items.Add(dr2[0]);
			}
			bgl.baglanti().Close();
		}

		private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
		{
			CmbDoktor.Items.Clear();

			using (SqlConnection baglanti = bgl.baglanti())
			{
				using (SqlCommand komut3 = new SqlCommand("GetDoctorsByBranch", baglanti)) //procedure
				{
					komut3.CommandType = CommandType.StoredProcedure;
					komut3.Parameters.AddWithValue("@branchName", CmbBrans.Text);

					using (SqlDataReader dr3 = komut3.ExecuteReader())
					{
						while (dr3.Read())
						{
							CmbDoktor.Items.Add(dr3.GetString(0) + " " + dr3.GetString(1));
						}
					}
				}
			}
		}

		private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
		{

			DataTable dt = new DataTable();
			using (SqlConnection connection = bgl.baglanti())
			{
				string query = "select RandevuID, RandevuTarih as 'Tarih', RandevuSaat as 'Saat', BransAd as 'Branş', DoktorAd+' '+DoktorSoyad as 'Doktor' from Tbl_Randevular inner join Tbl_Branslar on Tbl_Randevular.RandevuBrans = Tbl_Branslar.BransID inner join Tbl_Doktorlar on Tbl_Randevular.RandevuDoktor = Tbl_Doktorlar.DoktorID  WHERE Tbl_Doktorlar.DoktorAd + ' ' + Tbl_Doktorlar.DoktorSoyad = @DoktorAd AND Tbl_Randevular.RandevuDurum = 0";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@BransAd", CmbBrans.Text);
					command.Parameters.AddWithValue("@DoktorAd", CmbDoktor.Text);

					SqlDataAdapter da = new SqlDataAdapter(command);
					da.Fill(dt);
				}
			}
			dataGridView2.DataSource = dt;
		}

		private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FrmHastaBilgiDuzenle fr = new FrmHastaBilgiDuzenle();
			fr.TCno = LblTC.Text;
			fr.Show();
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView2.SelectedCells[0].RowIndex;
			TxtID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
		}

		private void BtnRandevuAl_Click(object sender, EventArgs e)
		{
			HastaIslem islem = new HastaIslem();
			islem.HastaRandevu(LblTC.Text, RchSikayet.Text, Convert.ToInt32(TxtID.Text));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FrmDuyurular frd = new FrmDuyurular();
			frd.Show();
		}
	}
}
