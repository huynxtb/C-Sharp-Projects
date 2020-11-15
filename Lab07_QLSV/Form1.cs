using Lab07_QLSV.dao;
using Lab07_QLSV.dao.impl;
using Lab07_QLSV.DAO;
using Lab07_QLSV.DAO.impl;
using Lab07_QLSV.dto;
using Lab07_QLSV.utils;
using System;
using System.Data;
using System.Reflection;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab07_QLSV
{
    public partial class MainForm : Form
    {
        private static IStudentDAO studentDAO = new StudentDAO();
        private static IMajorDAO majorDAO = new MajorDAO();
        private static IPointDAO pointDAO = new PointDAO();
        private static ISubjectDAO subjectDAO = new SubjectDAO();
        private int sex;
        private int studentCode;
        private string majorCode = "";
        private string subCode = "";
        public MainForm()
        {
            InitializeComponent();
            ResourceDB.resourceDB = "Lab07_QLSV.database";
            this.CenterToScreen();
        }

        private bool isEmptyTxtStudent()
        {
            if (Validation.CheckEmptyTextbox(txtStudentCode, "Vui lòng nhập mã sinh viên")) return false;
            if (Validation.CheckEmptyTextbox(txtStudentName, "Vui lòng nhập tên sinh viên")) return false;
            if (Validation.CheckEmptyTextbox(txtAddress, "Vui lòng nhập địa chỉ sinh viên")) return false;
            if (Validation.CheckEmptyTextbox(txtPhone, "Vui lòng nhập sđt sinh viên")) return false;
            return true;
        }
        private bool isEmptyTxtMajor()
        {
            if (Validation.CheckEmptyTextbox(txtMajorCode, "Vui lòng nhập mã khoa")) return false;
            if (Validation.CheckEmptyTextbox(txtMajorName, "Vui lòng nhập tên khoa")) return false;
            return true;
        }
        private bool isEmptyTxtSubject()
        {
            if (Validation.CheckEmptyTextbox(txtMaMH, "Vui lòng nhập mã môn")) return false;
            if (Validation.CheckEmptyTextbox(txtTenMH, "Vui lòng nhập tên môn")) return false;
            if (Validation.CheckEmptyTextbox(txtSoTiet, "Vui lòng nhập số tiết")) return false;
            return true;
        }
        private bool isEmptyTxtPoint()
        {
            if (Validation.CheckEmptyTextbox(txtMSSV, "Vui lòng nhập MSSV")) return false;
            if (Validation.CheckEmptyTextbox(txtDiemMHH, "Vui lòng nhập mã môn học")) return false;
            if (Validation.CheckEmptyTextbox(txtDiem, "Vui lòng nhập điểm")) return false;
            if (int.Parse(txtDiem.Text) > 10 || int.Parse(txtDiem.Text) < 0)
            {
                MessageBox.Show("Vui lòng nhập trong khoảng 0-10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void loadData()
        {
            this.khoaTableAdapter1.Fill(this.lab07csharpDataSet8.Khoa);
            this.ketQuaTableAdapter.Fill(this.lab07csharpDataSet4.KetQua);
            this.monTableAdapter.Fill(this.lab07csharpDataSet3.Mon);
            this.khoaTableAdapter.Fill(this.lab07csharpDataSet2.Khoa);
            this.sinhVienTableAdapter.Fill(this.lab07csharpDataSet1.SinhVien);
            dgvTKK.Rows.Clear();
            DataTable dt = majorDAO.FindAll();
            foreach (DataRow dr in dt.Rows)
            {
                dgvTKK.Rows.Add(dr.ItemArray);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();

        }
        private bool isExistedStudent()
        {
            return (studentDAO.IsExistedBy(txtStudentCode.Text).Rows.Count > 0) ? true : false;
        }
        private bool isExistedMajor() 
        {
            return (majorDAO.IsExistedBy(txtMajorCode.Text).Rows.Count > 0) ? true : false;
        }
        private bool isExistedSubject() 
        {
            return (subjectDAO.IsExistedBy(txtMaMH.Text).Rows.Count > 0) ? true : false;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (rbtFamle.Checked)
            {
                sex = 0;
            }
            if (rbtMale.Checked)
            {
                sex = 1;
            }

            if (!isExistedStudent())
            {
                if (isEmptyTxtStudent())
                {
                    StudentDTO dto = new StudentDTO();
                    dto.code = int.Parse(txtStudentCode.Text);
                    dto.fullName = txtStudentName.Text;
                    dto.birthDay = dtpDate.Value.Date;
                    dto.sex = sex;
                    dto.address = txtAddress.Text;
                    dto.phone = txtPhone.Text;
                    dto.majorCode = cbbMajorCode.SelectedValue.ToString();
                    //Console.WriteLine(dto.majorCode);
                    if (studentDAO.Insert(dto)) MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Thêm thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (rbtFamle.Checked)
            {
                sex = 0;
            }
            if (rbtMale.Checked)
            {
                sex = 1;
            }

            if (isEmptyTxtStudent())
            {
                StudentDTO dto = new StudentDTO();
                dto.code = studentCode;
                dto.fullName = txtStudentName.Text;
                dto.birthDay = dtpDate.Value.Date;
                dto.sex = sex;
                dto.address = txtAddress.Text;
                dto.phone = txtPhone.Text;
                dto.majorCode = cbbMajorCode.SelectedValue.ToString();

                if (studentDAO.Update(dto))
                {
                    MessageBox.Show("Sửa thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                    MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                StudentDTO dto = new StudentDTO();
                dto.code = studentCode;
                if (studentDAO.Delete(dto))
                {
                    MessageBox.Show("Xoá thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt.clearTextBox(this);
                    loadData();
                }
                else
                    MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                studentCode = Int32.Parse(dgvSinhVien.Rows[index].Cells[0].Value.ToString());
                txtStudentCode.Text = dgvSinhVien.Rows[index].Cells[0].Value.ToString();
                txtStudentName.Text = dgvSinhVien.Rows[index].Cells[1].Value.ToString();
                dtpDate.Value = (DateTime)dgvSinhVien.Rows[index].Cells[2].Value;
                Console.WriteLine(dgvSinhVien.Rows[index].Cells[3].Value);
                if (Boolean.Parse(dgvSinhVien.Rows[index].Cells[3].Value.ToString()) == true)
                {
                    rbtMale.Checked = true;
                    rbtFamle.Checked = false;
                }
                if (Boolean.Parse(dgvSinhVien.Rows[index].Cells[3].Value.ToString()) == false)
                {
                    rbtFamle.Checked = true;
                    rbtMale.Checked = false;
                }
                txtAddress.Text = dgvSinhVien.Rows[index].Cells[4].Value.ToString();
                txtPhone.Text = dgvSinhVien.Rows[index].Cells[5].Value.ToString();
                cbbMajorCode.SelectedValue = dgvSinhVien.Rows[index].Cells[6].Value;
            }
        }

        private void btnCancelStudent_Click(object sender, EventArgs e)
        {
            ClearTxt.clearTextBox(this);
        }

        private void txtStudentCode_TextChanged(object sender, EventArgs e)
        {
            RegexNumber(txtStudentCode, "Vui lòng nhập số (Not string)");
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            RegexNumber(txtPhone, "Vui lòng nhập số (Not string)");
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tbpSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = studentDAO.Count();
            MessageBox.Show("Tổng số sinh viên: "+count.ToString());
        }

        private void btnAddMajor_Click(object sender, EventArgs e)
        {

            if (!isExistedMajor())
            {
                if (isEmptyTxtMajor())
                {
                    MajorDTO dto = new MajorDTO();
                    dto.code = txtMajorCode.Text;
                    dto.majorName = txtMajorName.Text;
                    if (majorDAO.Insert(dto)) MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else MessageBox.Show("Thêm thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Mã khoa đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEditMajor_Click(object sender, EventArgs e)
        {
            if (isEmptyTxtMajor())
            {
                MajorDTO dto = new MajorDTO();
                dto.code = majorCode;
                dto.majorName = txtMajorName.Text;
                if (majorDAO.Update(dto))
                {
                    MessageBox.Show("Sửa thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                    MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMajor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MajorDTO dto = new MajorDTO();
                dto.code = majorCode;
                if (majorDAO.Delete(dto))
                {
                    MessageBox.Show("Xoá thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt.clearTextBox(this);
                    loadData();
                }
                else
                    MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTxt.clearTextBox(this);
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                majorCode = dgvKhoa.Rows[index].Cells[0].Value.ToString();
                txtMajorCode.Text = dgvKhoa.Rows[index].Cells[0].Value.ToString();
                txtMajorName.Text = dgvKhoa.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void btnAddMH_Click(object sender, EventArgs e)
        {
            if (!isExistedSubject())
            {
                if (isEmptyTxtSubject())
                {
                    SubjectDTO dto = new SubjectDTO();
                    dto.code = txtMaMH.Text;
                    dto.name = txtTenMH.Text;
                    dto.nOfLesssons = int.Parse(txtSoTiet.Text);
                    if (subjectDAO.Insert(dto)) MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    else MessageBox.Show("Thêm thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Mã môn đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMH_Click(object sender, EventArgs e)
        {
            if (isEmptyTxtSubject())
            {
                SubjectDTO dto = new SubjectDTO();
                dto.code = subCode;
                dto.name = txtTenMH.Text;
                dto.nOfLesssons = int.Parse(txtSoTiet.Text);

                if (subjectDAO.Update(dto))
                {
                    MessageBox.Show("Sửa thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                    MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelMH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SubjectDTO dto = new SubjectDTO();
                dto.code = subCode;
                if (subjectDAO.Delete(dto))
                {
                    MessageBox.Show("Xoá thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt.clearTextBox(this);
                    loadData();
                }
                else
                    MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelMH_Click(object sender, EventArgs e)
        {
            ClearTxt.clearTextBox(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isExistedStudent() && isExistedSubject())
            {
                if (isEmptyTxtPoint())
                {
                    PointDTO dto = new PointDTO();
                    dto.stdCode = int.Parse(txtMSSV.Text);
                    dto.subCode = txtDiemMHH.Text;
                    dto.point = float.Parse(txtDiem.Text);
                    if (pointDAO.Insert(dto)) MessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Thêm thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("MSSV hoặc mã môn không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isEmptyTxtPoint())
            {
                PointDTO dto = new PointDTO();
                dto.stdCode = int.Parse(txtMSSV.Text);
                dto.subCode = txtDiemMHH.Text;
                dto.point = float.Parse(txtDiem.Text);
                if (pointDAO.Update(dto))
                {
                    MessageBox.Show("Sửa thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                    MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PointDTO dto = new PointDTO();
                dto.stdCode = int.Parse(txtMSSV.Text);
                dto.subCode = txtDiemMHH.Text;
                dto.point = float.Parse(txtDiem.Text);
                if (pointDAO.Delete(dto))
                {
                    MessageBox.Show("Xoá thành công", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTxt.clearTextBox(this);
                    loadData();
                }
                else
                    MessageBox.Show("Lỗi hệ thống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ClearTxt.clearTextBox(this);
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                subCode = dgvMonHoc.Rows[index].Cells[0].Value.ToString();
                txtMaMH.Text = dgvMonHoc.Rows[index].Cells[0].Value.ToString();
                txtTenMH.Text = dgvMonHoc.Rows[index].Cells[1].Value.ToString();
                txtSoTiet.Text = dgvMonHoc.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMSSV.Text = dgvDiem.Rows[index].Cells[0].Value.ToString();
                txtDiemMHH.Text = dgvDiem.Rows[index].Cells[1].Value.ToString();
                txtDiem.Text = dgvDiem.Rows[index].Cells[2].Value.ToString();
            }
        }
        
        private void RegexNumber(TextBox text, string s)
        {
            if (Regex.IsMatch(text.Text, "[^0-9]"))
            {
                MessageBox.Show(s, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text.Text = "";
                text.Focus();
            }
        }

        private void txtSoTiet_TextChanged(object sender, EventArgs e)
        {
            RegexNumber(txtSoTiet, "Vui lòng nhập số (Not string)");
        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {
            RegexNumber(txtDiem, "Vui lòng nhập số (Not string)");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSearchDiem.Rows.Clear();
            if (!string.IsNullOrEmpty(txtSearchPoint.Text))
            {
                DataTable dt = null; 
                if (!isExistedStudent())
                {
                     dt = pointDAO.FindByMSSV(int.Parse(txtSearchPoint.Text));
                    // dgvSearchDiem.DataSource = dt;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvSearchDiem.Rows.Add(dr.ItemArray);
                    }
                }
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy mã " + txtSearchPoint.Text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập MSSV", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchPoint.Focus();
            }
        }

        private void cbbKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            // SELECT COUNT(MaSo), MaKhoa FROM SinhVien GROUP BY MaKhoa ORDER BY COUNT(MaKhoa) DESC


        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            RegexNumber(txtMSSV, "Vui lòng nhập số (Not string)");
        }

        private void txtSearchPoint_TextChanged(object sender, EventArgs e)
        {
            RegexNumber(txtSearchPoint, "Vui lòng nhập số (Not string)");
        }
    }
}
