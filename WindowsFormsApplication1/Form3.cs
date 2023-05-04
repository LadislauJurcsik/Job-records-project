using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void informatiiDespreMeseriiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ss = new Form4();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 ss = new Form5();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ss = new Form6();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 ss = new Form7();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa iesiti din aplicatie?", "iesire din aplicatie", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();

                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 ss = new Form8();
            ss.Show();
        }
    }
}
