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
    public partial class Form3_1 : Form
    {
        public Form3_1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        public void SifreDeğiştir()
        {
            try
            {
                baglanti.Open();
                string kayit = "update kullanicibilgi set sifre=@p1 where kullaniciadi='" + textBox4.Text + "'";
                SqlCommand guncelle = new SqlCommand(kayit, baglanti);
                guncelle.Parameters.AddWithValue("@p1", textBox2.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                label4.Visible = true;
                label4.ForeColor = Color.Green;
                label4.Text = "Şifre Başarıyla Değiştirildi";
            }
            catch (Exception)
            {
                label4.Visible = true;
                label4.ForeColor = Color.Red;
                label4.Text = "Şifre Değiştirme Hatası";
            }

        }
        private void button1_Click(object sender, EventArgs e)

        {
            if (textBox2.Text == textBox2.Text)
            {
                if (textBox2.Text != "" && textBox3.Text != "" && textBox3.Text != "")
                {
                    SifreDeğiştir();
                }
                else
                {
                    label4.Visible = true;
                    label4.ForeColor = Color.Red;
                    label4.Text = "Alanları Boş Bırakmayınız";
                }
            }
            else
            {
                label4.Visible = true;
                label4.ForeColor = Color.Red;
                label4.Text = "Şifreler Eşleşmiyor";
            }
        }

        private void Form3_1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            try
            {
                SqlCommand mevcutsifre = new SqlCommand();
                baglanti.Open();
                mevcutsifre.Connection = baglanti;
                mevcutsifre.CommandText = "select * from kullanicibilgi where kullaniciadi='" + textBox4.Text + "'";
                SqlDataReader dr = mevcutsifre.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["sifre"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                label4.Visible = true;
                label4.ForeColor = Color.Red;
                label4.Text = "Mevcut Şifre Getirilemiyor";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.UseSystemPasswordChar = true;
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
                textBox1.UseSystemPasswordChar = false;
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
