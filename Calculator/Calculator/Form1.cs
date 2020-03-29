using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            double Number1 = double.Parse(num1.Text);
            double Number2 = double.Parse(num2.Text);

            double Result = Number1 + Number2;

            Ans.Text = Result.ToString();
        
        }

        private void sub_Click(object sender, EventArgs e)
        {
            double Number1 = double.Parse(num1.Text);
            double Number2 = double.Parse(num2.Text);

            double Result = Number1 - Number2;

            Ans.Text = Result.ToString();

        }

        private void multi_Click(object sender, EventArgs e)
        {
            double Number1 = double.Parse(num1.Text);
            double Number2 = double.Parse(num2.Text);

            double Result = Number1 * Number2;

            Ans.Text = Result.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            double Number1 = double.Parse(num1.Text);
            double Number2 = double.Parse(num2.Text);

            double Result = Number1 / Number2;

            Ans.Text = Result.ToString();

        }
    }
}
