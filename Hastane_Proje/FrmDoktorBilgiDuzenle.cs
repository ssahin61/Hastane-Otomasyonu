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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string TCNO;

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCNO;

			// Branşları ComboBox'a ekle
			SqlCommand komutBranslar = new SqlCommand("SELECT BransAd FROM Tbl_Branslar", bgl.baglanti());
			SqlDataReader drBranslar = komutBranslar.ExecuteReader();
			while (drBranslar.Read())
			{
				CmbBrans.Items.Add(drBranslar["BransAd"].ToString());
			}
			drBranslar.Close();

			// Doktorun ait olduğu bilgileri çek ve form elemanlarına atama
			SqlCommand komutDoktor = new SqlCommand("SELECT DoktorBrans, DoktorAd, DoktorSoyad, DoktorSifre FROM Tbl_Doktorlar WHERE DoktorTC=@p1", bgl.baglanti());
			komutDoktor.Parameters.AddWithValue("@p1", mskTC.Text);
			SqlDataReader drDoktor = komutDoktor.ExecuteReader();
			if (drDoktor.Read())
			{
				string doktorBransID = drDoktor["DoktorBrans"].ToString();
				txtAd.Text = drDoktor["DoktorAd"].ToString();
				TxtSoyad.Text = drDoktor["DoktorSoyad"].ToString();
				txtSifre.Text = drDoktor["DoktorSifre"].ToString();

				// Doktorun branş adını al
				SqlCommand komutBransAdi = new SqlCommand("SELECT BransAd FROM Tbl_Branslar WHERE BransID=@p1", bgl.baglanti());
				komutBransAdi.Parameters.AddWithValue("@p1", doktorBransID);
				string doktorBransAdi = (string)komutBransAdi.ExecuteScalar();
				CmbBrans.Text = doktorBransAdi;
			}
			drDoktor.Close();

			bgl.baglanti().Close();
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
        {
			SqlCommand komut = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd = @p1, DoktorSoyad = @p2, DoktorBrans = (SELECT BransID FROM Tbl_Branslar WHERE BransAd = @p3), DoktorSifre = @p4 WHERE DoktorTC = @p5", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", CmbBrans.Text); 
			komut.Parameters.AddWithValue("@p4", txtSifre.Text);
			komut.Parameters.AddWithValue("@p5", mskTC.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Kayıt Başarıyla Güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
