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
using System.Security.Policy;

namespace Hastane_Proje
{
	public partial class FrmHastaKayit : Form
	{
		public FrmHastaKayit()
		{
			InitializeComponent();
		}

		sqlbaglantisi bgl = new sqlbaglantisi();

		private void BtnKayıtOl_Click(object sender, EventArgs e)
		{
			HastaIslem islem = new HastaIslem();
			islem.HastaKayit(txtAd.Text, TxtSoyad.Text, mskTC.Text, MskTEL.Text, TxtSifre.Text, CmbCinsiyet.Text);
			MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir, Şifreniz: " + TxtSifre.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
