using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            if (text1.Equals("admin") && text2.Equals("admin")) {
                MessageBox.Show("Bravo.");
            }
            else
            {
                MessageBox.Show("Try again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
            form7.FormClosed += new FormClosedEventHandler(Form6_FormClosed);
        }
        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
