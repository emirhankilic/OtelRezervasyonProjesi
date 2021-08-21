using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace OtelRezervasyonProjesi
{
    public partial class Form7 : Form
    {
       public static string tc = "";
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }
       
        public void kayitGetir()
        {
            Form6 frm = new Form6();

            tc = Form6.tc;
            bag.Open();
            
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM [rezervasyonistekleri] where [tc]=@veri2", bag);
            cmd2.Parameters.AddWithValue("@veri2", tc.ToString());

            
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            bag.Close();
            if (bag.State == ConnectionState.Closed)
                bag.Open();
            string sorgu = "DELETE FROM rezervasyonistekleri where tc =@p9";
            SqlCommand cmd34 = new SqlCommand(sorgu, bag);
            cmd34.Parameters.AddWithValue("@p9", tc);

            cmd34.ExecuteNonQuery();
           
        }
        public void Form7_Load(object sender, EventArgs e)
        {
            
        kayitGetir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 FRM = new Form2();
            this.Hide();
            FRM.Show();

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);

            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
