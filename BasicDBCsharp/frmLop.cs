using BasicDBCsharp.dao;
using BasicDBCsharp.dao.impl;
using BasicDBCsharp.dto;
using BasicDBCsharp.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicDBCsharp
{
    public partial class frmLop : Form
    {
        private string MaLop = "";
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basiccsharpDataSet.lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.basiccsharpDataSet.lop);

        }
        private bool isExistedClass() { return (ClassDAO.GetInstance.IsExistedBy(txtMaLop.Text).Rows.Count > 0) ? true : false; }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClassDTO dto = new ClassDTO();
            dto.MaLop = txtMaLop.Text;
            dto.TenLop = txtTenLop.Text;
            dto.Year = int.Parse(txtNam.Text);
            if (!isExistedClass())
            {
                if (ClassDAO.GetInstance.Insert(dto))
                {
                    MessageBox.Show("Thêm thành công");
                    this.lopTableAdapter.Fill(this.basiccsharpDataSet.lop);
                }
                else
                {
                    MessageBox.Show("Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Mã lớp đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClassDTO dto = new ClassDTO();
            dto.MaLop = MaLop;
            dto.TenLop = txtTenLop.Text;
            dto.Year = int.Parse(txtNam.Text);

            if (ClassDAO.GetInstance.Update(dto))
            {
                MessageBox.Show("Sửa thành công");
                this.lopTableAdapter.Fill(this.basiccsharpDataSet.lop);
            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClassDTO dto = new ClassDTO();
            dto.MaLop = MaLop;
            if (ClassDAO.GetInstance.Delete(dto))
            {
                MessageBox.Show("Xoá thành công");
                this.lopTableAdapter.Fill(this.basiccsharpDataSet.lop);
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void dgvLopd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                MaLop = dgvLopd.Rows[index].Cells[0].Value.ToString();
                txtMaLop.Text = dgvLopd.Rows[index].Cells[0].Value.ToString();
                txtTenLop.Text = dgvLopd.Rows[index].Cells[1].Value.ToString();
                txtNam.Text = dgvLopd.Rows[index].Cells[2].Value.ToString();
            }
        }
    }
}
