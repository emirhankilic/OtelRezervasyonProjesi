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
    public partial class Form3_3 : Form
    {
        public Form3_3()
        {
            InitializeComponent();
        }
        private void Form3_3_Load(object sender, EventArgs e)
        {
      
        }
        SqlConnection conn= new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
       
        private void Button1_Click(object sender, EventArgs e)
        {
            
           
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "DELETE FROM kullanicibilgi where id =" + textBox4.Text + "";
            SqlCommand cmd = new SqlCommand(sorgu, conn);
            DialogResult secenek = MessageBox.Show("Silme işlemini onaylıyormusunuz ?", " Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı…");
                textBox4.Text = "";
            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("İşlem Yapılmadı…");
                textBox4.Text = "";
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

       
    
   
    



