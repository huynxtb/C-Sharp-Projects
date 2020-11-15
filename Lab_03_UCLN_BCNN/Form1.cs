using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_UCLN_BCNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void validNumber(TextBox text)
        {
            text.TextAlign = HorizontalAlignment.Center;
            if (System.Text.RegularExpressions.Regex.IsMatch(text.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                text.Text = "";
                text.Focus();
            }
        }

        private int ucln(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b; 
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        private int bcnn(int a, int b)
        {
            return a * b / ucln(a, b);
        }
        private void txtNumberA_TextChanged(object sender, EventArgs e)
        {
            validNumber(txtNumberA);
        }

        private void txtNumberB_TextChanged(object sender, EventArgs e)
        {
            validNumber(txtNumberB);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNumberA.Text) && !string.IsNullOrEmpty(txtNumberB.Text))
            {
                int a = Int32.Parse(txtNumberA.Text);
                int b = Int32.Parse(txtNumberB.Text);
                int result = 0;
                if (rbtUCLN.Checked)
                {
                    result = ucln(a, b);
                    txtResult.Text = result.ToString();
                }
                if (rbtBCNN.Checked)
                {
                    result = bcnn(a, b);
                    txtResult.Text = result.ToString();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ 2 số A và B!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }

            rbtUCLN.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
