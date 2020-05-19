using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycounter
{
    public partial class Form1 : Form
    {
        int op1, op2;
        char op;
        bool clearbtn = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        //設定數字鍵,以及歸零
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (clearbtn)
            {
                label1.Text = "0";
                clearbtn = false;
            }

            if (label1.Text == "0") label1.Text = btn.Text;
            else label1.Text += btn.Text;


        }

        //設定數學式
        private void opa(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op = Convert.ToChar(btn.Text);
            op1 = Convert.ToInt32(label1.Text);
            clearbtn = true;

        }
        //計算結果
        private void finish(object sender, EventArgs e)
        {
            op2 = Convert.ToInt32(label1.Text);
            switch (op)
                {
                case '+':
                    label1.Text = "" + (op1 + op2);
                    break;
                case '-':
                    label1.Text = "" + (op1 - op2);
                    break;
                case '*':
                    label1.Text = "" + (op1 * op2);
                    break;
                case '/':
                    label1.Text = "" + (op1 / op2);
                    break;
            }
        }
    }
}
