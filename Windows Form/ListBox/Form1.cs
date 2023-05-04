using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_button1_Click(object sender, EventArgs e)
        {
            FruitslistBox1.Items.Add(textBox1.Text);

            textBox1.Clear();
            textBox1.Focus();
        }

        private void Count_items_button2_Click(object sender, EventArgs e)
        {
            int count = FruitslistBox1.Items.Count;
            MessageBox.Show("Items count is:" + count.ToString());
        }

        private void Short_button3_Click(object sender, EventArgs e)
        {
            FruitslistBox1.Sorted= true;
        }

        private void Remove_Specificitems_button4_Click(object sender, EventArgs e)
        {
            FruitslistBox1.Items.Remove(FruitslistBox1.SelectedItem);
            //FruitslistBox1.Items.RemoveAt(FruitslistBox1.SelectedIndex);
        }

        private void clear_button1_Click(object sender, EventArgs e)
        {
            FruitslistBox1.Items.Clear();
        }
    }
}
