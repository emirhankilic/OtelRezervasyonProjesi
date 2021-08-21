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
    public partial class Form6 : Form
    {
        public static string tc="", adi, soyadi, giristarihi, cikistarihi, odaid;
        
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();

        }
      
        private void kayitGetir()
        {
            bag.Open();
            string kayit = "SELECT * from rezervasyonistekleri";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, bag);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            bag.Close();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            kayitGetir();

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void aktar()
        {
            
            try
            {
               
                bag.Open();
                string kayit = "update odabilgi set adi=@p1,soyadi=@p2,giristarih=@p3,cıkıstarih=@p4,aktif=@p7  where id=@p5";
                SqlCommand guncelle = new SqlCommand(kayit, bag);
                guncelle.Parameters.AddWithValue("@p1", adi);
                guncelle.Parameters.AddWithValue("@p2", soyadi);
                guncelle.Parameters.AddWithValue("@p3", giristarihi);
                guncelle.Parameters.AddWithValue("@p4", cikistarihi);
                guncelle.Parameters.AddWithValue("@p5", odaid);
                guncelle.Parameters.AddWithValue("@p7", "dolu");



                guncelle.ExecuteNonQuery();
                Form4 frm = new Form4();
               
                bag.Close();
               
                MessageBox.Show("rezervasyon onay işlemi başarıyla sonuçlandı");

            }
            catch (Exception)
            {
                MessageBox.Show("hata");
            }

        }

     public void button1_Click(object sender, EventArgs e)
        {
           
            tc = textBox1.Text;
            string tcc = tc;
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [adi] from [rezervasyonistekleri] where [tc]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", tc);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                adi = dr["adi"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [soyadi] from [rezervasyonistekleri] where [tc]=@veri2", bag);
            cmd3.Parameters.AddWithValue("@veri2", tc);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                soyadi = dr3["soyadi"].ToString();
            }


            bag.Close();

            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [giristarihi] from [rezervasyonistekleri] where [tc]=@veri2", bag);
            cmd4.Parameters.AddWithValue("@veri2", tc);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            if (dr4.Read())
            {
                giristarihi = dr4["giristarihi"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [cıkıstarihi] from [rezervasyonistekleri] where [tc]=@veri2", bag);
            cmd5.Parameters.AddWithValue("@veri2", tc);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                cikistarihi = dr5["cıkıstarihi"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [odaid] from [rezervasyonistekleri] where [tc]=@veri2", bag);
            cmd6.Parameters.AddWithValue("@veri2", tc);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            if (dr6.Read())
            {
                odaid = dr6["odaid"].ToString();
            }
            bag.Close();
            aktar();
            
             Form7 frm = new Form7();
            this.Hide();
            frm.Show();




            tc = tcc;
        }
       
    }
}
