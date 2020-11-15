using Lab08_DanhMucNhanVien.Model;
using Lab08_DanhMucNhanVien.Service;
using Lab08_DanhMucNhanVien.Service.impl;
using Lab08_DanhMucNhanVien.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_DanhMucNhanVien
{
    public partial class FormNhanVien : Form
    {
        private IEmployeeService employeeService = Singleton<EmployeeService>.Instances;
        private int CodeNV;
        public FormNhanVien()
        {
            InitializeComponent();
            string sql = "INSERT INTO NHANVIEN (HoTenNhanVien, NgaySinh, DiaChi, DienThoai, MaBangCap) VALUES ( @HoTenNhanVien , @NgaySinh , @DiaChi , @DienThoai , @MaBangCap )";
            string[] listParam = sql.Split(' ');
            int i = 0;
            foreach (string item in listParam)
            {
                if (item.Contains('@'))
                {
                    Console.WriteLine(item);
                    i++;
                }
            }
        }
        private bool isEmptyTxtNV()
        {
            if (Validation.IsEmptyTxt(txtNameNV, "Vui lòng nhập tên")) return false;
            if (Validation.IsEmptyTxt(txtAddressNV, "Vui lòng nhập địa chỉ")) return false;
            if (Validation.IsEmptyTxt(txtPhoneNV, "Vui lòng nhập sđt")) return false;
            if (Validation.CheckInt(txtPhoneNV, "Sđt không đúng")) return false;
            return true;
        }
        private void loadData()
        {
            this.bANGCAPTableAdapter.Fill(this.lab08chsarpDataSet1.BANGCAP);
            this.nHANVIENTableAdapter.Fill(this.lab08chsarpDataSet.NHANVIEN);
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                CodeNV = Int32.Parse(dgvNhanVien.Rows[index].Cells[0].Value.ToString());
                txtNameNV.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
                dtpDateNV.Value = (DateTime)dgvNhanVien.Rows[index].Cells[2].Value;
                txtAddressNV.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
                txtPhoneNV.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
                cbbBangCapNV.SelectedValue = dgvNhanVien.Rows[index].Cells[5].Value;
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (isEmptyTxtNV())
            {
                EmployeeModel model = new EmployeeModel();
                model.FullName = txtNameNV.Text;
                model.Date = dtpDateNV.Value;
                model.Address = txtAddressNV.Text;
                model.Phone = txtPhoneNV.Text;
                model.MaBangCap = int.Parse(cbbBangCapNV.SelectedValue.ToString());
                if (employeeService.Insert(model))
                {
                    MessageBox.Show("Thêm thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bái", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            if (isEmptyTxtNV())
            {
                EmployeeModel model = new EmployeeModel();
                model.Code = CodeNV;
                model.FullName = txtNameNV.Text;
                model.Date = dtpDateNV.Value;
                model.Address = txtAddressNV.Text;
                model.Phone = txtPhoneNV.Text;
                model.MaBangCap = int.Parse(cbbBangCapNV.SelectedValue.ToString());
                if (employeeService.Update(model))
                {
                    MessageBox.Show("Sửa thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bái", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int code = CodeNV;
                if (employeeService.Delete(code))
                {
                    MessageBox.Show("Xoá thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleatTxt.Clear(this);
                    loadData();
                }
                else
                    MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelNV_Click(object sender, EventArgs e)
        {
            CleatTxt.Clear(this);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
