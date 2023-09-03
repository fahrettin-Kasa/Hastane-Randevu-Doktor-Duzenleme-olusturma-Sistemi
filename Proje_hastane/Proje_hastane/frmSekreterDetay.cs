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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCNO;
        sql_baglantisi bgl = new sql_baglantisi();  
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNO;  

            //Ad Soyad

            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from tbl_sekreter where SekreterTC=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader(); 
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();
            
            // bransları aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView4.DataSource = dt1; 

            //Doktorları cekmek

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' ,DoktorBrans from tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2); 
            dataGridView5.DataSource = dt2;

            //brans cekmek
            SqlCommand komut2 = new SqlCommand("select BransAd from tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0].ToString());  
            }
            bgl.baglanti().Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into tbl_randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutKaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutKaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutKaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Kaydı Oluşturuldu");
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]); 
            }
            bgl.baglanti().Close();  
        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");


        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli drp = new frmDoktorPaneli();
            drp.Show();
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            frmbrans frb = new frmbrans();
            frb.Show();
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            frmRandevuListesi frr = new frmRandevuListesi();    
            frr.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            frmDuyurular frd = new frmDuyurular();
            frd.Show();
        }
    }
}
