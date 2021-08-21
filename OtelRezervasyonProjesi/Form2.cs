using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OtelRezervasyonProjesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fr = new Form3();
            fr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fr = new Form4();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 fr = new Form5();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 fr = new Form6();
            fr.Show();
        }
    }
}
