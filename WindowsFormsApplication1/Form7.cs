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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meseriDataSet3.tabel' table. You can move, or remove it, as needed.
            this.tabelTableAdapter.Fill(this.meseriDataSet3.tabel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ss = new Form3();
            ss.Show();
        }

        private void ordonareToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabelTableAdapter.ordonare(this.meseriDataSet3.tabel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabelTableAdapter.ordonare(this.meseriDataSet3.tabel);
        }
    }
}
