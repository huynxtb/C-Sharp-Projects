using BasicDBCsharp.dao;
using BasicDBCsharp.dao.impl;
using BasicDBCsharp.dto;
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
    public partial class frmSinhVien : Form
    {

        string mssv = "";
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private bool isExistedStd() { return (StudentDAO.GetInstance.IsExistedBy(txtMSSV.Text).Rows.Count > 0) ? true : false; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentDTO dto = new StudentDTO();
            dto.MSSV = txtMSSV.Text;
            dto.HoTen = txtHoTen.Text;
            dto.MaLop = cbbMaLop.SelectedValue.ToString();

            if (!isExistedStd())
            {
                if (StudentDAO.GetInstance.Insert(dto))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentDTO dto = new StudentDTO();
            dto.MSSV = mssv;
            dto.HoTen = txtHoTen.Text;
            dto.MaLop = cbbMaLop.SelectedValue.ToString();

            if (StudentDAO.GetInstance.Update(dto))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Thất Bại");
            }
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentDTO dto = new StudentDTO();
            dto.MSSV = mssv;
            if (StudentDAO.GetInstance.Delete(dto))
            {
                MessageBox.Show("Xoá thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
            LoadData();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                mssv = dgvSinhVien.Rows[index].Cells[0].Value.ToString();
                txtMSSV.Text = dgvSinhVien.Rows[index].Cells[0].Value.ToString();
                txtHoTen.Text = dgvSinhVien.Rows[index].Cells[1].Value.ToString();
                cbbMaLop.SelectedValue = dgvSinhVien.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            frm.Show();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // TODO: This line of code loads data into the 'basiccsharpDataSet3.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter1.Fill(this.basiccsharpDataSet3.SinhVien);
            // TODO: This line of code loads data into the 'basiccsharpDataSet2.lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.basiccsharpDataSet2.lop);
            // TODO: This line of code loads data into the 'basiccsharpDataSet1.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.basiccsharpDataSet1.SinhVien);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = StudentDAO.GetInstance.Count();
            MessageBox.Show("Tổng số sinh viên: "+count.ToString());
        }
    }
}
