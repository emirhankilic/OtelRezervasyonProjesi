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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        
        private void button13_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();

        }
        public void k101()
        {
            string aktiflik = "";
            string texta = "", textb = "";
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [aktif] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k101");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr["aktif"].ToString();
                aktiflik = dr["aktif"].ToString();
               
            
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [giristarih] from [odabilgi] where [id]=@veri3", bag);
            cmd3.Parameters.AddWithValue("@veri3", "k101");
            SqlDataReader dr2 = cmd3.ExecuteReader();
            if (dr2.Read())
            {
                label7.Text = dr2["giristarih"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [cıkıstarih] from [odabilgi] where [id]=@veri4", bag);
            cmd4.Parameters.AddWithValue("@veri4", "k101");
            SqlDataReader dr3 = cmd4.ExecuteReader();
            if (dr3.Read())
            {
                label8.Text = dr3["cıkıstarih"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [adi] from [odabilgi] where [id]=@veri5", bag);
            cmd5.Parameters.AddWithValue("@veri5", "k101");
            SqlDataReader dr4 = cmd5.ExecuteReader();
            if (dr4.Read())
            {
                texta = dr4["adi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [soyadi] from [odabilgi] where [id]=@veri6", bag);
            cmd6.Parameters.AddWithValue("@veri6", "k101");
            SqlDataReader dr5 = cmd6.ExecuteReader();
            if (dr5.Read())
            {
                textb = dr5["soyadi"].ToString();
            }

            bag.Close();
            label6.Text = texta + " " + textb;
         

        }
        public void k102()
        {
            string aktiflik2="";
            string texta = "", textb = "";
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [aktif] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k102");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                label12.Text = dr["aktif"].ToString();
                aktiflik2 = dr["aktif"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [giristarih] from [odabilgi] where [id]=@veri3", bag);
            cmd3.Parameters.AddWithValue("@veri3", "k102");
            SqlDataReader dr2 = cmd3.ExecuteReader();
            if (dr2.Read())
            {
                label10.Text = dr2["giristarih"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [cıkıstarih] from [odabilgi] where [id]=@veri4", bag);
            cmd4.Parameters.AddWithValue("@veri4", "k102");
            SqlDataReader dr3 = cmd4.ExecuteReader();
            if (dr3.Read())
            {
                label9.Text = dr3["cıkıstarih"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [adi] from [odabilgi] where [id]=@veri5", bag);
            cmd5.Parameters.AddWithValue("@veri5", "k102");
            SqlDataReader dr4 = cmd5.ExecuteReader();
            if (dr4.Read())
            {
                texta = dr4["adi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [soyadi] from [odabilgi] where [id]=@veri6", bag);
            cmd6.Parameters.AddWithValue("@veri6", "k102");
            SqlDataReader dr5 = cmd6.ExecuteReader();
            if (dr5.Read())
            {
                textb = dr5["soyadi"].ToString();
            }

            bag.Close();
            label11.Text = texta + " " + textb;
           



        }
        public void k103()
        {
            string aktiflik3 = "";
            string texta = "", textb = "";
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [aktif] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k103");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                label20.Text = dr["aktif"].ToString();
                aktiflik3 = dr["aktif"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [giristarih] from [odabilgi] where [id]=@veri3", bag);
            cmd3.Parameters.AddWithValue("@veri3", "k103");
            SqlDataReader dr2 = cmd3.ExecuteReader();
            if (dr2.Read())
            {
                label18.Text = dr2["giristarih"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [cıkıstarih] from [odabilgi] where [id]=@veri4", bag);
            cmd4.Parameters.AddWithValue("@veri4", "k103");
            SqlDataReader dr3 = cmd4.ExecuteReader();
            if (dr3.Read())
            {
                label17.Text = dr3["cıkıstarih"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [adi] from [odabilgi] where [id]=@veri5", bag);
            cmd5.Parameters.AddWithValue("@veri5", "k103");
            SqlDataReader dr4 = cmd5.ExecuteReader();
            if (dr4.Read())
            {
                texta = dr4["adi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [soyadi] from [odabilgi] where [id]=@veri6", bag);
            cmd6.Parameters.AddWithValue("@veri6", "k103");
            SqlDataReader dr5 = cmd6.ExecuteReader();
            if (dr5.Read())
            {
                textb = dr5["soyadi"].ToString();
            }

            bag.Close();
            label19.Text = texta + " " + textb;
          





        }
        public void k201()
        {
            string aktiflik4 = "";
            string texta = "", textb = "";
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [aktif] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k201");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                label28.Text = dr["aktif"].ToString();
                aktiflik4 = dr["aktif"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [giristarih] from [odabilgi] where [id]=@veri3", bag);
            cmd3.Parameters.AddWithValue("@veri3", "k201");
            SqlDataReader dr2 = cmd3.ExecuteReader();
            if (dr2.Read())
            {
                label26.Text = dr2["giristarih"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [cıkıstarih] from [odabilgi] where [id]=@veri4", bag);
            cmd4.Parameters.AddWithValue("@veri4", "k201");
            SqlDataReader dr3 = cmd4.ExecuteReader();
            if (dr3.Read())
            {
                label25.Text = dr3["cıkıstarih"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [adi] from [odabilgi] where [id]=@veri5", bag);
            cmd5.Parameters.AddWithValue("@veri5", "k201");
            SqlDataReader dr4 = cmd5.ExecuteReader();
            if (dr4.Read())
            {
                texta = dr4["adi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [soyadi] from [odabilgi] where [id]=@veri6", bag);
            cmd6.Parameters.AddWithValue("@veri6", "k201");
            SqlDataReader dr5 = cmd6.ExecuteReader();
            if (dr5.Read())
            {
                textb = dr5["soyadi"].ToString();
            }

            bag.Close();
            label27.Text = texta + " " + textb;
           



        }
        public void k202()
        {
            string aktiflik5 = "";
            string texta = "", textb = "";
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [aktif] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k202");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                label36.Text = dr["aktif"].ToString();
                aktiflik5 = dr["aktif"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [giristarih] from [odabilgi] where [id]=@veri3", bag);
            cmd3.Parameters.AddWithValue("@veri3", "k202");
            SqlDataReader dr2 = cmd3.ExecuteReader();
            if (dr2.Read())
            {
                label34.Text = dr2["giristarih"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [cıkıstarih] from [odabilgi] where [id]=@veri4", bag);
            cmd4.Parameters.AddWithValue("@veri4", "k202");
            SqlDataReader dr3 = cmd4.ExecuteReader();
            if (dr3.Read())
            {
                label33.Text = dr3["cıkıstarih"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [adi] from [odabilgi] where [id]=@veri5", bag);
            cmd5.Parameters.AddWithValue("@veri5", "k202");
            SqlDataReader dr4 = cmd5.ExecuteReader();
            if (dr4.Read())
            {
                texta = dr4["adi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [soyadi] from [odabilgi] where [id]=@veri6", bag);
            cmd6.Parameters.AddWithValue("@veri6", "k202");
            SqlDataReader dr5 = cmd6.ExecuteReader();
            if (dr5.Read())
            {
                textb = dr5["soyadi"].ToString();
            }

            bag.Close();
            label35.Text = texta + " " + textb;
           


        }
        public void k203()
        {
            string aktiflik6 = "";
            string texta = "", textb = "";
            bag.Open();
            SqlCommand cmd2 = new SqlCommand("select [aktif] from [odabilgi] where [id]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", "k203");
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                label44.Text = dr["aktif"].ToString();
                aktiflik6 = dr["aktif"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd3 = new SqlCommand("select [giristarih] from [odabilgi] where [id]=@veri3", bag);
            cmd3.Parameters.AddWithValue("@veri3", "k203");
            SqlDataReader dr2 = cmd3.ExecuteReader();
            if (dr2.Read())
            {
                label42.Text = dr2["giristarih"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd4 = new SqlCommand("select [cıkıstarih] from [odabilgi] where [id]=@veri4", bag);
            cmd4.Parameters.AddWithValue("@veri4", "k203");
            SqlDataReader dr3 = cmd4.ExecuteReader();
            if (dr3.Read())
            {
                label41.Text = dr3["cıkıstarih"].ToString();
            }
            bag.Close();

            bag.Open();
            SqlCommand cmd5 = new SqlCommand("select [adi] from [odabilgi] where [id]=@veri5", bag);
            cmd5.Parameters.AddWithValue("@veri5", "k203");
            SqlDataReader dr4 = cmd5.ExecuteReader();
            if (dr4.Read())
            {
                texta = dr4["adi"].ToString();
            }
            bag.Close();
            bag.Open();
            SqlCommand cmd6 = new SqlCommand("select [soyadi] from [odabilgi] where [id]=@veri6", bag);
            cmd6.Parameters.AddWithValue("@veri6", "k203");
            SqlDataReader dr5 = cmd6.ExecuteReader();
            if (dr5.Read())
            {
                textb = dr5["soyadi"].ToString();
            }

            bag.Close();
            label43.Text = texta + " " + textb;
           

        }

        public void Form4_Load(object sender, EventArgs e)
        {
            k101();
            k102();
            k103();
            k201();
            k202();
            k203();
           
               
                

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE odabilgi SET adi = @p1, soyadi = @p2,giristarih=@p3,cıkıstarih=@p4,aktif=@p5 WHERE id = @alan";
            SqlCommand command = new SqlCommand(sorgu, bag);
            command.Parameters.AddWithValue("@p1", " ");
            command.Parameters.AddWithValue("@p2", " ");
            command.Parameters.AddWithValue("@p3", " ");
            command.Parameters.AddWithValue("@p4", " ");
            command.Parameters.AddWithValue("@p5", "bos");
            command.Parameters.AddWithValue("@alan", "k101");
            bag.Open();
            command.ExecuteNonQuery();
            bag.Close();
            button1.BackColor = Color.LimeGreen;
            MessageBox.Show("k101 numaralı oda kapatılıyor "," ", MessageBoxButtons.OKCancel);

            


        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE odabilgi SET adi = @p1, soyadi = @p2,giristarih=@p3,cıkıstarih=@p4,aktif=@p5 WHERE id = @alan";
            SqlCommand command = new SqlCommand(sorgu, bag);
            command.Parameters.AddWithValue("@p1", " ");
            command.Parameters.AddWithValue("@p2", " ");
            command.Parameters.AddWithValue("@p3", " ");
            command.Parameters.AddWithValue("@p4", " ");
            command.Parameters.AddWithValue("@p5", "bos");
            command.Parameters.AddWithValue("@alan", "k102");
            bag.Open();
            command.ExecuteNonQuery();
            bag.Close();
            button2.BackColor = Color.LimeGreen;
            MessageBox.Show("k102 numaralı oda kapatılıyor ", " ", MessageBoxButtons.OKCancel);


        }




        private void button9_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE odabilgi SET adi = @p1, soyadi = @p2,giristarih=@p3,cıkıstarih=@p4,aktif=@p5 WHERE id = @alan";
            SqlCommand command = new SqlCommand(sorgu, bag);
            command.Parameters.AddWithValue("@p1", " ");
            command.Parameters.AddWithValue("@p2", " ");
            command.Parameters.AddWithValue("@p3", " ");
            command.Parameters.AddWithValue("@p4", " ");
            command.Parameters.AddWithValue("@p5", "bos");
            command.Parameters.AddWithValue("@alan", "k103");
            bag.Open();
            command.ExecuteNonQuery();
            bag.Close();
            button3.BackColor = Color.LimeGreen;
            MessageBox.Show("k103 numaralı oda kapatılıyor ", " ", MessageBoxButtons.OKCancel);



        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE odabilgi SET adi = @p1, soyadi = @p2,giristarih=@p3,cıkıstarih=@p4,aktif=@p5  WHERE id = @alan";
            SqlCommand command = new SqlCommand(sorgu, bag);
            command.Parameters.AddWithValue("@p1", " ");
            command.Parameters.AddWithValue("@p2", " ");
            command.Parameters.AddWithValue("@p3", " ");
            command.Parameters.AddWithValue("@p4", " ");
            command.Parameters.AddWithValue("@p5", "bos");
            command.Parameters.AddWithValue("@alan", "k201");
            bag.Open();
            command.ExecuteNonQuery();
            bag.Close();
            button4.BackColor = Color.LimeGreen;
            MessageBox.Show("k201 numaralı oda kapatılıyor ", " ", MessageBoxButtons.OKCancel);


        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE odabilgi SET adi = @p1, soyadi = @p2,giristarih=@p3,cıkıstarih=@p4,aktif=@p5  WHERE id = @alan";
            SqlCommand command = new SqlCommand(sorgu, bag);
            command.Parameters.AddWithValue("@p1", " ");
            command.Parameters.AddWithValue("@p2", " ");
            command.Parameters.AddWithValue("@p3", " ");
            command.Parameters.AddWithValue("@p4", " ");
            command.Parameters.AddWithValue("@p5", "bos");
            command.Parameters.AddWithValue("@alan", "k202");
            bag.Open();
            command.ExecuteNonQuery();
            bag.Close();
            button5.BackColor = Color.LimeGreen;
            MessageBox.Show("k202 numaralı oda kapatılıyor ", " ", MessageBoxButtons.OKCancel);


        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE odabilgi SET adi = @p1, soyadi = @p2,giristarih=@p3,cıkıstarih=@p4,aktif=@p5  WHERE id = @alan";
            SqlCommand command = new SqlCommand(sorgu, bag);
            command.Parameters.AddWithValue("@p1", " ");
            command.Parameters.AddWithValue("@p2", " ");
            command.Parameters.AddWithValue("@p3", " ");
            command.Parameters.AddWithValue("@p4", " ");
            command.Parameters.AddWithValue("@p5", "bos");
            command.Parameters.AddWithValue("@alan", "k203");
            bag.Open();
            command.ExecuteNonQuery();
            bag.Close();
            button6.BackColor = Color.LimeGreen;
            MessageBox.Show("k203 numaralı oda kapatılıyor ", " ", MessageBoxButtons.OKCancel);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm = new Form4();
            frm.Show();

        }
    }
}
