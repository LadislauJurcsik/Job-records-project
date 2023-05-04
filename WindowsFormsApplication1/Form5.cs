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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meseriDataSet1.tabel' table. You can move, or remove it, as needed.
            this.tabelTableAdapter.Fill(this.meseriDataSet1.tabel);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabelTableAdapter.FillBy(this.meseriDataSet1.tabel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            Single n = Convert.ToSingle(this.tabelTableAdapter.nr(a));
            if (n != 0)
            {
                this.tabelTableAdapter.Cautare(this.meseriDataSet1.tabel, a);
            }
            else MessageBox.Show("Nu exista meseria cautata");
        }

        private void cautareToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabelTableAdapter.Cautare(this.meseriDataSet1.tabel, wToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ss = new Form3();
            ss.Show();
        }
    }
}
