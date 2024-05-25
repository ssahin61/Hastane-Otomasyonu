using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
	public class SekreterIslem
	{
		public void RandevuOlustur(string tarih, string saat, string brans, string doktor, bool durum, string tc)
		{
			sqlbaglantisi bgl = new sqlbaglantisi();
			using (SqlConnection baglanti = bgl.baglanti())
			{
				string query = "INSERT INTO Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor, RandevuDurum, HastaTC) VALUES (@r1, @r2, (SELECT BransID FROM Tbl_Branslar WHERE BransAd = @r3), (SELECT DoktorID FROM Tbl_Doktorlar WHERE DoktorAd + ' ' + DoktorSoyad = @r4), @r5, @r6)";
				using (SqlCommand komutkaydet = new SqlCommand(query, baglanti))
				{
					komutkaydet.Parameters.AddWithValue("@r1", tarih);
					komutkaydet.Parameters.AddWithValue("@r2", saat);
					komutkaydet.Parameters.AddWithValue("@r3", brans);
					komutkaydet.Parameters.AddWithValue("@r4", doktor);
					komutkaydet.Parameters.AddWithValue("@r5", durum);
					komutkaydet.Parameters.AddWithValue("@r6", tc);
					komutkaydet.ExecuteNonQuery(); // using blogu bağlantıyı kendisi kapatıyor..
					MessageBox.Show("Randevu Başarıyla Oluşturuldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		public void DuyuruOlustur(string duyuru)
		{
			sqlbaglantisi bgl = new sqlbaglantisi();
			SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
			komut.Parameters.AddWithValue("@d1", duyuru);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Duyuru Başarıyla Oluşturuldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
