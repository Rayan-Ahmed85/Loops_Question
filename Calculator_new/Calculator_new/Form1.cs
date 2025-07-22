using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1;
        double num2;
        string operation;
        double result;
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text+button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button4.Text;
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button10.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = Convert.ToDouble(TextBox.Text);
            TextBox.Text = "";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(TextBox.Text); 
            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                result = num1 / num2;
            }
            TextBox.Text = "Result : " + result;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(TextBox.Text);
            double square = num1 * num1;
            TextBox.Text = square.ToString();
        }
    }
}
