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
	public class HastaIslem
	{
		sqlbaglantisi bgl = new sqlbaglantisi();
		public void HastaKayit(string ad, string soyad, string tc, string tel, string sifre, string cinsiyet)
		{
			using (SqlConnection baglanti = bgl.baglanti())
			{
				string query = "INSERT INTO Tbl_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTEL, HastaSifre, HastaCinsiyet) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
				using (SqlCommand komut = new SqlCommand(query, baglanti))
				{
					komut.Parameters.AddWithValue("@p1", ad);
					komut.Parameters.AddWithValue("@p2", soyad);
					komut.Parameters.AddWithValue("@p3", tc);
					komut.Parameters.AddWithValue("@p4", tel);
					komut.Parameters.AddWithValue("@p5", sifre);
					komut.Parameters.AddWithValue("@p6", cinsiyet);
					komut.ExecuteNonQuery();
				}
			}
		}

		public void HastaRandevu(string tc, string sikayet, int id)
		{
			using (SqlConnection baglanti = bgl.baglanti())
			{
				SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 where RandevuID=@p3", baglanti);
				komut.Parameters.AddWithValue("@p1", tc);
				komut.Parameters.AddWithValue("@p2", sikayet);
				komut.Parameters.AddWithValue("@p3", id);
				komut.ExecuteNonQuery();
			}
			MessageBox.Show("Randevu Başarıyla Kaydedildi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}


	}
}




