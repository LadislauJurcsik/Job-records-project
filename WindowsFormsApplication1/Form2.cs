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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "elev")
            {
                if (textBox2.Text == "123456")
                {
                    this.Hide();
                    Form3 ss = new Form3();
                    ss.Show();
                }
                else MessageBox.Show("parola este incorecta");
            }
            else MessageBox.Show("utilizatorul este incorect");
        }
    }
}
