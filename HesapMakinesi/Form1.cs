using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1;
        string op;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtValue.Text);
            op = "+";

        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtValue.Text);
            op = "*";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtValue.Text);
            op = "-";
        }

        private void btnDividedBy_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtValue.Text);
            op = "/";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double number2 = Convert.ToDouble(txtValue.Text);
            double result=0;
            number2 = Convert.ToDouble(txtValue.Text);
            if( op == "+")
            {
                result = number1 + number2;
            }
            else if (op == "-")
            {
                result = number1 - number2;
            }
            else if (op == "*")
            {
                result = number1 * number2;
            }
            else if (op == "/")
            {
                result = number1 / number2;
            }
            txtValue.Text = result.ToString();
        }
    }
    }
    

