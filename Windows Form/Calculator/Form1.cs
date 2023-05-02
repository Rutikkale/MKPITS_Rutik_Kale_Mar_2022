using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addtion_Button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="" && textBox2.Text !="")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int Result = num1 + num2;

                label4.Text = "Addtion Result is: " + Result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("please Fill both fields !!");
            }
            
        }

        private void Subtraction_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int Result = num1 - num2;

                label4.Text = "Subtraction Result is: " + Result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("please Fill both fields !!");
            }
        }

        private void Multiplcation_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int Result = num1 * num2;

                label4.Text = "Multiplication Result is: " + Result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("please Fill both fields !!");
            }
        }

        private void Division_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int Result = num1 / num2;

                label4.Text = "Division Result is: " + Result.ToString();
                label4.Visible = true;
            }
            else
            {
                MessageBox.Show("please Fill both fields !!");
            }
        }
    }
}
