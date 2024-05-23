using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazilim_proje2
{
    public partial class uyeGoruntule : Form
    {
        public uyeGoruntule()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\sporDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        
        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from uyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uyeGoruntule_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anaSayfa log = new anaSayfa();
            log.Show();
            this.Hide();
        }

        private void adFiltrele()
        {
            baglanti.Open();
            string query = "select * from uyeTbl where UYEisim='" + textBox1.Text + "'";
            SqlDataAdapter sda= new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder= new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adFiltrele();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeler();
        }
    }
}
