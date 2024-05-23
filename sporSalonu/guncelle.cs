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
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\sporDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from uyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void guncelle_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Öncelikle tıklanan satırın geçerli olup olmadığını kontrol ediyoruz.
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                key = Convert.ToInt32(row.Cells[0].Value.ToString());

                adtxt.Text = row.Cells[1].Value.ToString();
                teltxt.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                yastxt.Text = row.Cells[4].Value.ToString();
                tutartxt.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adtxt.Text = "";
            teltxt.Text = "";
            comboBox1.Text = "";
            yastxt.Text = "";
            tutartxt.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anaSayfa anasyf =  new anaSayfa();
            anasyf.Show();
            this.Hide();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("silinecek üyeyi seçiniz.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from uyeTbl where UYEid=" + key + ";";
                    SqlCommand komut = new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("üye başarıyla silindi.");
                    baglanti.Close();
                    uyeler();

                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0||adtxt.Text==""||teltxt.Text==""||comboBox1.Text==""||yastxt.Text==""||tutartxt.Text=="")
            {
                MessageBox.Show("eksik bilgi.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update uyeTbl set UYEisim='"+adtxt.Text+"',UYEtel='"+teltxt.Text+"',UYEcinsiyet='"+comboBox1.Text+"',UYEyas='"+yastxt.Text+"',UYEodeme='"+tutartxt.Text+"'WHERE UYEid="+key+";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("üye başarıyla güncellendi.");
                    baglanti.Close();
                    uyeler();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
