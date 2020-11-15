using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_3_Thuc_Hien_Phep_Tinh
{
    public partial class Form1 : Form
    {
        double a, b, result = 0;

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtNumberA.Select();
        }

        private void checkDigit(TextBox textBox)
        {
            if (Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Hãy nhập số tự nhiên! Nhập lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Text = "";
                textBox.Focus();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void parseDigit()
        {
            a = Double.Parse(txtNumberA.Text.Trim());
            b = Double.Parse(txtNumberB.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parseDigit();
            result = a + b;
            txtResult.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parseDigit();
            result = a - b;
            txtResult.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parseDigit();
            result = a * b;
            txtResult.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (b == 0)
            {
                 MessageBox.Show("Không thể thực hiện phép chia cho 0! Nhập lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumberB.Text = "";
                txtNumberB.Focus();
            }
            else
            {
                parseDigit();
                result = a / b;
                txtResult.Text = result.ToString();
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkDigit(txtNumberA);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkDigit(txtNumberB);
        }
    }
}
