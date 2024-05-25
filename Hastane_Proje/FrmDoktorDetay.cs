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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string TC;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
			LblTC.Text = TC;

            //Doktor Ad Soyad çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //Randevuları çekme
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select RandevuID, RandevuTarih as 'Tarih', RandevuSaat as 'Saat', BransAd as 'Branş', DoktorAd+' '+DoktorSoyad as 'Doktor', RandevuDurum, HastaTC, HastaSikayet from Tbl_Randevular inner join Tbl_Branslar on Tbl_Randevular.RandevuBrans=Tbl_Branslar.BransID inner join Tbl_Doktorlar on Tbl_Randevular.RandevuDoktor=Tbl_Doktorlar.DoktorID where DoktorAd+' '+DoktorSoyad='" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frd = new FrmDoktorBilgiDuzenle();
            frd.TCNO = LblTC.Text;
            frd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

	}
}
