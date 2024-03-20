using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_03
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
        private void Calculate(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            Button selector = (Button)sender;

            if (selector.Text == "+")
            {
                result = x + y;
            }
            else if (selector.Text == "-")
            {
                result = x - y;
            }
            else if (selector.Text == "x")
            {
                result = x * y;
            }
            else if (selector.Text == "/")
            {
                result = x / y;
            }
            
            label4.Text = Convert.ToString(result);
        }
    }
}
