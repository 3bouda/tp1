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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            if (int.TryParse(text1, out int text1Int))
            {
                if (int.TryParse(text2, out int text2Int))
                {
                    textBox3.Text = (text1Int + text2Int).ToString();
                }
                else
                MessageBox.Show("Please enter a valid integer in the second TextBox.");
            }
            else
                MessageBox.Show("Please enter a valid integer in the first TextBox.");

    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            form3.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
        }
    }
}
