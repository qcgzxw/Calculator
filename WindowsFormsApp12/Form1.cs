using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        double num1, num2, reasult;//num1,num2用于保存操作数，reasult用于保存运算结果
        bool decimalFlag = false;//decimaFlag判断是否为小数，默认为false（不是小数）
        string myOperator;
        public void but_ban2()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }
        public void but_enable2()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
        }
            public void but_ban()
        {
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
        }
        public void but_enable()
        {
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
        }
        public void NumClick(int myNumber)
        {
            if (decimalFlag)
            {
                textBox1.Text = textBox1.Text + myNumber; 
            }
            else
            {
                if(textBox1.Text == "0.")
                    textBox1.Text = myNumber + ".";
                else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1) + myNumber + "."; 
            }
            but_enable();


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0."; 
            textBox1.TextAlign = HorizontalAlignment.Right;
            but_enable2();
            but_ban();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NumClick(0); 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            decimalFlag = true; 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            decimalFlag = false;
            textBox1.Text = "0.";
            label1.Text = "运算过程：\n";
            but_enable2();
            but_ban();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumClick(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumClick(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumClick(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumClick(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumClick(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumClick(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumClick(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumClick(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumClick(9);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            myOperator = "add";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = "0.";
            decimalFlag = false;
            label1.Text += Convert.ToString(num1) + "+";
            but_ban();
            but_enable2();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            myOperator = "sub";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = "0.";
            decimalFlag = false;
            label1.Text += Convert.ToString(num1) + "-";
            but_ban();
            but_enable2();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            myOperator = "mul";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = "0.";
            decimalFlag = false;
            label1.Text += Convert.ToString(num1) + "×";
            but_ban();
            but_enable2();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            myOperator = "div";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = "0.";
            decimalFlag = false;
            label1.Text += Convert.ToString(num1) + "÷";
            but_ban();
            but_enable2();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            switch(myOperator)
            {
                case "add":
                    reasult = num1 + num2;
                    textBox1.Text = reasult.ToString();
                    break;
                case "sub":
                    reasult = num1 - num2;
                    textBox1.Text = reasult.ToString();
                    break;
                case "mul":
                    reasult = num1 * num2;
                    textBox1.Text = reasult.ToString();
                    break;
                case "div":
                    if(num2 == 0)
                    {
                        textBox1.Text = "除数不能为“0”！";
                    }
                    else {
                        reasult = num1 / num2;
                        textBox1.Text = reasult.ToString();
                    }
                    break;
            }

            label1.Text += Convert.ToString(num2) + "=" + Convert.ToString(reasult) + "\n";
            but_ban2();
        }
    }
}
