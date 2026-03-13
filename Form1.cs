using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fruitlistbox.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LIST ITEMS:"+Fruitlistbox.Items.Count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fruitlistbox.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fruitlistbox.Items.Remove(Fruitlistbox.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fruitlistbox.Items.Clear();
        }
    }
}
