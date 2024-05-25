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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma",10);
			DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT RandevuID, RandevuTarih as 'Tarih', RandevuSaat as 'Saat', BransAd as 'Branş', DoktorAd+' '+DoktorSoyad as 'Doktor', RandevuDurum, HastaTC, HastaSikayet from Tbl_Randevular inner join Tbl_Branslar on Tbl_Randevular.RandevuBrans=Tbl_Branslar.BransID inner join Tbl_Doktorlar on Tbl_Randevular.RandevuDoktor=Tbl_Doktorlar.DoktorID", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
