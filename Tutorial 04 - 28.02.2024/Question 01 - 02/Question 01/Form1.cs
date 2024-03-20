using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_01
{
    public partial class Form1 : Form
    {
        public int x;
        public int y;
        public int result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            result = x + y;

            label4.Text = Convert.ToString(result);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            result = x - y;

            label4.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            result = x * y;

            label4.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            result = x / y;

            label4.Text = Convert.ToString(result);
        }
    }
}
