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

namespace yazilim_proje2
{
    public partial class uyeEkle : Form
    {
        public uyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\sporDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void uyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adsydtxt.Text == "" || teltxt.Text == "" || odemetxt.Text == ""||yastxt.Text=="")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    
                    string query ="insert into uyeTbl values('"+adsydtxt.Text+"','"+teltxt.Text+"','"+comboBox1.SelectedItem.ToString()+"','"+yastxt.Text+"','"+odemetxt.Text+"')";
                    SqlCommand cmd=new SqlCommand(query,baglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla eklendi.");
                    baglanti.Close();
                    adsydtxt.Text = "";
                    teltxt.Text = "";
                    odemetxt.Text = "";
                    yastxt.Text = "";
                    comboBox1.Text = "";  // üye kledikten sonra da textboxları temizledik.
                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adsydtxt.Text = "";
            teltxt.Text = "";
            odemetxt.Text = "";
            yastxt.Text = "";
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           anaSayfa syf = new anaSayfa();
            syf.Show();// ana sayfaya geri döndük.
            this.Hide();
        }
    }
}
