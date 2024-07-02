using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
            form4.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            if (int.TryParse(text1, out int text1Int))
            {
                if (text1Int % 2 == 0)
                {
                    label2.Text = "le nombre " + text1Int + " est pair";
                }else
                {
                    label2.Text = "le nombre " + text1Int + " est impair";
                }
            }
            else
                MessageBox.Show("Please enter a valid integer in the TextBox.");
        }
    }
}
