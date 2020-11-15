using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05_DanhMucSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private bool checkEmptyText()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        item.Focus();
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = dgvInfomation.Rows.Count;
            if (!checkEmptyText())
            {
                dgvInfomation.Rows.Add();
                dgvInfomation.Rows[index].Cells["name"].Value = txtName.Text;
                dgvInfomation.Rows[index].Cells["date"].Value = dtpDateOfBirth.Value.ToString("dd/MM/yyyy");
                dgvInfomation.Rows[index].Cells["phone"].Value = txtPhone.Text;
                dgvInfomation.Rows[index].Cells["address"].Value = txtAddress.Text;
            }
            else
            {
                MessageBox.Show("Hãy chắc chắn bạn đã nhập đủ thông tin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvInfomation.SelectedRows.Count > 0)
            {
                dgvInfomation.SelectedRows[0].Cells["name"].Value = txtName.Text;
                dgvInfomation.SelectedRows[0].Cells["date"].Value = dtpDateOfBirth.Value.ToString("dd/MM/yyyy");
                dgvInfomation.SelectedRows[0].Cells["phone"].Value = txtPhone.Text;
                dgvInfomation.SelectedRows[0].Cells["address"].Value = txtAddress.Text;
            }
            else
            {
                MessageBox.Show("Chưa mục nào được chọn", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int dgvCount = dgvInfomation.Rows.Count;
            int selected = dgvInfomation.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (dgvCount > 0)
            {
                if (selected > 0)
                {
                    foreach (DataGridViewRow item in dgvInfomation.SelectedRows)
                    {
                        dgvInfomation.Rows.Remove(item);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn mục", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa có sinh viên nào trong bảng", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if(!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "^[0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Text = "";
            }
        }

        private void dgvInfomation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtName.Text = dgvInfomation.Rows[index].Cells["name"].Value.ToString();
                txtPhone.Text = dgvInfomation.Rows[index].Cells["phone"].Value.ToString();
                txtAddress.Text = dgvInfomation.Rows[index].Cells["address"].Value.ToString();
                dtpDateOfBirth.Value = DateTime.ParseExact(dgvInfomation.Rows[index].Cells["date"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }
    }
}
