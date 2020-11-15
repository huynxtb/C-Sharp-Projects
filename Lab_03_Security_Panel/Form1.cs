using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_Security_Panel
{
    public partial class Form1 : Form
    {
        private string[] s = { "Technicians", "Custodians", "Scientist", "Restricted Access!" };
        private String time = DateTime.Now.ToString();
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            txtCode.TextAlign = HorizontalAlignment.Center;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCode.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers");
                txtCode.Text = "";
                txtCode.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Please input code!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
            }
            else
            {
                try
                {
                    switch (Int32.Parse(txtCode.Text))
                    {
                        case 1645:
                            MessageBox.Show($"Welcome {s[0]}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listBox.Items.Add(time + " - " + s[0]);
                            txtCode.Text = "";
                            break;
                        case 1689:
                            MessageBox.Show($"Welcome {s[0]}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listBox.Items.Add(time + " - " + s[0]);
                            txtCode.Text = "";
                            break;
                        case 8345:
                            MessageBox.Show($"Welcome {s[1]}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listBox.Items.Add(time + " - " + s[1]);
                            txtCode.Text = "";
                            break;
                        case 9998:
                            MessageBox.Show($"Welcome {s[2]}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listBox.Items.Add(time + " - " + s[2]);
                            txtCode.Text = "";
                            break;
                        case 1006:
                            MessageBox.Show($"Welcome {s[2]}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listBox.Items.Add(time + " - " + s[2]);
                            txtCode.Text = "";
                            break;
                        case 1008:
                            MessageBox.Show($"Welcome {s[2]}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listBox.Items.Add(time + " - " + s[2]);
                            txtCode.Text = "";
                            break;
                        default:
                            MessageBox.Show("Access denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            listBox.Items.Add(time + " - " + s[3]);
                            txtCode.Text = "";
                            break;
                    }
                    using (StreamWriter file = new StreamWriter(@"file.txt", true))
                    {
                        file.WriteLine(listBox.Items[listBox.Items.Count - 1]);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button b = new Button
                {
                    Text = i.ToString(),
                    Width = 57,
                    Height = 57,
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                    ForeColor = Color.Black
                };
                b.MouseClick += new MouseEventHandler((o, a) =>
                {
                    txtCode.Text += b.Text;
                });
                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
