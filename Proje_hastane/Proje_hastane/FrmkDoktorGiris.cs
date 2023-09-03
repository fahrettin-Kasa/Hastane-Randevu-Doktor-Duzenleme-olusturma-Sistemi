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
namespace Proje_hastane
{
    public partial class FrmkDoktorGiris : Form
    {
        public FrmkDoktorGiris()
        {
            InitializeComponent();
        }
        sql_baglantisi bgl = new sql_baglantisi();
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frd = new FrmDoktorDetay();
                frd.TC = msktc.Text;     
                frd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı Giriş Yaptınız");
            }
            bgl.baglanti().Close(); 
        }
    }
}
