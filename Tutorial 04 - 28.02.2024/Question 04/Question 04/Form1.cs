using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_04
{
    public partial class Form1 : Form
    {
        public string display;
        public int num1;
        public int num2;
        public Button Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            Button Numbers = (Button)sender;
            if (textBox1.Text == "0")
            {
                if (Numbers.Text == "00")
                {
                    return;
                }
                textBox1.Clear();
            }
                textBox1.Text = textBox1.Text + Numbers.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Operators(object sender, EventArgs e)
        {
            textBox2.Clear();
            Operator = (Button)sender;
            num1 = Convert.ToInt32(textBox1.Text);
            textBox2.Text = textBox2.Text + textBox1.Text + $" {Operator.Text} ";
            textBox1.Text = "0";
        }

        private void Result(object sender, EventArgs e)
        {
            Button Result = (Button)sender;
            num2 = Convert.ToInt32(textBox1.Text);
            textBox2.Text = textBox2.Text + num2 + " = ";
            switch (Operator.Text)
            {
                case "+": 
                    display = Convert.ToString(num1+num2);
                    textBox1.Text = display;
                    break;
                case "-":
                    display = Convert.ToString(num1 - num2);
                    textBox1.Text = display;
                    break;
                case "*":
                    display = Convert.ToString(num1 * num2);
                    textBox1.Text = display;
                    break;
                case "÷":
                    display = Convert.ToString(num1 / num2);
                    textBox1.Text = display;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            display = "0";
            textBox1.Text = "0";
            textBox2.Text = "";
        }
    }
}
