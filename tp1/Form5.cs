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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
            form6.FormClosed += new FormClosedEventHandler(Form6_FormClosed);
        }
        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value1) && double.TryParse(textBox2.Text, out double value2))
            {
                // Determine which operation to perform
                double result = 0;
                if (radioButton1.Checked)
                {
                    result = value1 + value2;
                }
                else if (radioButton2.Checked)
                {
                    result = value1 - value2;
                }
                else if (radioButton3.Checked)
                {
                    result = value1 * value2;
                }
                else if (radioButton4.Checked)
                {
                    if (value2 != 0)
                    {
                        result = value1 / value2;
                    }
                    else
                    {
                        MessageBox.Show("Division by zero is not allowed.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select an operation.");
                    return;
                }

                // Display the result
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both input fields.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
