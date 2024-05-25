using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
	public class DoktorIslem
	{
		sqlbaglantisi bgl = new sqlbaglantisi();
		public void DoktorSil(string TC)
		{
			SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", TC);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Kayıt Başarıyla Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		public void DoktorEkle(string ad, string soyad, string bransAd, string tc, string sifre, string cinsiyet)
		{
			SqlCommand bransKomut = new SqlCommand("SELECT BransID FROM Tbl_Branslar WHERE BransAd = @bransAd", bgl.baglanti());
			bransKomut.Parameters.AddWithValue("@bransAd", bransAd);

			// BransID'yi almak için ExecuteScalar kullanıyoruz
			int bransID = Convert.ToInt32(bransKomut.ExecuteScalar());

			SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre, DoktorCinsiyet) VALUES (@d1, @d2, @d3, @d4, @d5, @d6)", bgl.baglanti());
			komut.Parameters.AddWithValue("@d1", ad);
			komut.Parameters.AddWithValue("@d2", soyad);
			komut.Parameters.AddWithValue("@d3", bransID); // Burada bransID kullanılıyor
			komut.Parameters.AddWithValue("@d4", tc);
			komut.Parameters.AddWithValue("@d5", sifre);
			komut.Parameters.AddWithValue("@d6", cinsiyet);

			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Doktor Başarıyla Eklendi", "Doktor Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		public void DoktorGuncelle(string ad, string soyad, string brans, string tc, string sifre, int ID)
		{
			SqlCommand komut = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd = @p1, DoktorSoyad = @p2, DoktorBrans = (SELECT BransID FROM Tbl_Branslar WHERE BransAd = @p3), DoktorSifre = @p4, DoktorTC=@p5 WHERE DoktorID = @p6", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", ad);
			komut.Parameters.AddWithValue("@p2", soyad);
			komut.Parameters.AddWithValue("@p3", brans);
			komut.Parameters.AddWithValue("@p4", sifre);
			komut.Parameters.AddWithValue("@p5", tc);
			komut.Parameters.AddWithValue("@p6", ID);

			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Kayıt Başarıyla Güncellendi!", "Doktor Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
