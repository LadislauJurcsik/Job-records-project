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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meseriDataSet2.tabel' table. You can move, or remove it, as needed.
            this.tabelTableAdapter.Fill(this.meseriDataSet2.tabel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ss = new Form3();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabelTableAdapter.ord(this.meseriDataSet2.tabel);
        }
        }
    
}
