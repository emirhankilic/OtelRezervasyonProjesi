using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OtelRezervasyonProjesi
{
    public partial class Form3_2 : Form
    {
        public Form3_2()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "INSERT INTO kullanicibilgi VALUES(@kul,@sif)";
                SqlCommand komut = new SqlCommand(sorgu, bag);
                komut.Parameters.AddWithValue("@kul", textBox1.Text);
                komut.Parameters.AddWithValue("@sif", textBox2.Text);
                bag.Open();
                komut.ExecuteNonQuery();
                bag.Close();
                MessageBox.Show("KAYIT BAŞARIYLA GERÇEKLEŞTİ");
            }
            catch (Exception hata)
            {
                if (bag.State == ConnectionState.Open) bag.Close();
                MessageBox.Show(hata.Message);
            }
        }

        private void Form3_2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}

