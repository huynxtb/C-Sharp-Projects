using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_ThaoTacSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnumber.Text))
            {
                listBox.Items.Add(txtnumber.Text);
                txtnumber.Text = "";
                txtnumber.Focus();
            }
            else
            {
                MessageBox.Show("Không được để trống phần này", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {
            txtnumber.TextAlign = HorizontalAlignment.Center;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtnumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Hãy nhập số nguyên", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnumber.Text = "";
                txtnumber.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = listBox.Items.Count;
            if (count != 0)
            {
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    listBox.Items[i] = Int32.Parse(listBox.Items[i].ToString()) + 2;
                }
            }
            else
            {
                MessageBox.Show("Không có phần tử nào trong danh sách", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = listBox.Items.Count;
            int dem = 0;
            if (count != 0)
            {
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    if (Int32.Parse(listBox.Items[i].ToString()) % 2 == 0)
                    {
                        listBox.SelectedIndex = i;
                        dem++;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có phần tử nào trong danh sách", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(dem == 0)
            {
                MessageBox.Show("Không có số chẵn nào", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = listBox.Items.Count;
            int dem = 0;
            if (count != 0)
            {
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    if (Int32.Parse(listBox.Items[i].ToString()) % 2 != 0)
                    {
                        listBox.SelectedIndex = i;
                        dem++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có phần tử nào trong danh sách", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (dem == 0)
            {
                MessageBox.Show("Không có số lẻ nào", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = listBox.Items.Count;
            int selected = listBox.SelectedItems.Count;
            if (count != 0)
            {
                for (int i = 0; i < selected; i++)
                {
                    listBox.Items.Remove(listBox.SelectedItems[i]);
                }
            }
            else
            {
                MessageBox.Show("Không có phần tử nào trong danh sách", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (selected == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử nào", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = listBox.Items.Count;
            if (count!=0)
            {
                listBox.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Không có phần tử nào trong danh sách", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = listBox.Items.Count;
            if (count != 0)
            {
                listBox.Items.RemoveAt(listBox.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Không có phần tử nào trong danh sách", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
