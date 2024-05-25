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
using System.Data.Common;

namespace Hastane_Proje
{
	public partial class FrmDuyurular : Form
	{
		public FrmDuyurular()
		{
			InitializeComponent();
		}

		sqlbaglantisi bgl = new sqlbaglantisi();

		private void FrmDuyurular_Load(object sender, EventArgs e)
		{
			this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 11);
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Duyurular", bgl.baglanti());
			da.Fill(dt);
			dataGridView1.DataSource = dt;

			dataGridView1.Columns["DuyuruID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridView1.Columns["Duyuru"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}
	}
}
