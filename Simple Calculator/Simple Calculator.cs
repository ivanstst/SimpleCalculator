using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            float answer;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            if (rbMinus.Checked == true)
            {
                answer = number1 - number2;
                textBox3.Text = answer.ToString();
            }
            if (rbPlus.Checked == true)
            {
                answer = number1 + number2;
                textBox3.Text = answer.ToString();
            }
            if (rbMultiply.Checked == true)
            {
                answer = number1*number2;
                textBox3.Text = answer.ToString();
            }

            if (rbDivide.Checked == true)
            {
                answer = number1 / number2;
                textBox3.Text = answer.ToString();
            }

            
        }

       
    }
}
