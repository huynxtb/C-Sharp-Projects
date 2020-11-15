using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void moveOne(ListBox listA, ListBox listB)
        {
            for (int i = 0; i < listA.SelectedItems.Count; i++)
            {
                listB.Items.Add(listA.SelectedItems[i].ToString());
                listA.Items.Remove(listA.SelectedItems[i]);
            }
        }

        private void moveAll(ListBox listA, ListBox listB)
        {
            for (int i = 0; i < listA.Items.Count; i++)
            {
                listB.Items.Add(listA.Items[i].ToString());
            }
            listA.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                listBoxClassA.Items.Add(txtName.Text);
                txtName.Text = "";
                txtName.Focus();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            moveOne(listBoxClassA, listBoxClassB);

        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            moveOne(listBoxClassB, listBoxClassA);
        }

        private void btnAllToRight_Click(object sender, EventArgs e)
        {
            moveAll(listBoxClassA, listBoxClassB);
        }

        private void btnAllToLeft_Click(object sender, EventArgs e)
        {
            moveAll(listBoxClassB, listBoxClassA);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBoxClassA.Items.Clear();
            listBoxClassB.Items.Clear();
        }
    }
}
