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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_1 frm = new Form3_1();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_2 frm = new Form3_2();
            frm.Show();

        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-TA0SVJJ\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_3 frm = new Form3_3();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();

        }
    }
}
