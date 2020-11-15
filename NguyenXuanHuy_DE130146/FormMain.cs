using NguyenXuanHuy_DE130146.util;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenXuanHuy_DE130146
{
    public partial class FormMain : Form
    {
        // Fix Them - Sua - Xoa - Search - Count

        private Entites db = new Entites();
        private Model supplier = new Model();
        private string Code = "";
        private int ID = -1;
        public FormMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        #region methods
        private bool isEmptyTxt()
        {
            if (Validation.CheckEmptyTextbox(txt_1, "Vui lòng nhập mã sinh viên")) return false;
            return true;
        }

        private void LoadData() 
        {
            dgvMainProgram.DataSource = (from s in db.Suppliers select s).ToList(); // Fix Suppliers
        }
        #endregion

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //if (index >= 0)
            //{

            //    studentCode = Int32.Parse(dgvSinhVien.Rows[index].Cells[0].Value.ToString());
            //    txtStudentCode.Text = dgvSinhVien.Rows[index].Cells[0].Value.ToString();
            //    txtStudentName.Text = dgvSinhVien.Rows[index].Cells[1].Value.ToString();
            //    dtpDate.Value = (DateTime)dgvSinhVien.Rows[index].Cells[2].Value;
            //    Console.WriteLine(dgvSinhVien.Rows[index].Cells[3].Value);
            //    if (Boolean.Parse(dgvSinhVien.Rows[index].Cells[3].Value.ToString()) == true)
            //    {
            //        rbtMale.Checked = true;
            //        rbtFamle.Checked = false;
            //    }
            //    if (Boolean.Parse(dgvSinhVien.Rows[index].Cells[3].Value.ToString()) == false)
            //    {
            //        rbtFamle.Checked = true;
            //        rbtMale.Checked = false;
            //    }
            //    txtAddress.Text = dgvSinhVien.Rows[index].Cells[4].Value.ToString();
            //    txtPhone.Text = dgvSinhVien.Rows[index].Cells[5].Value.ToString();
            //    cbbMajorCode.SelectedValue = dgvSinhVien.Rows[index].Cells[6].Value;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string check = "Facebook";

            var item = (from s in db.Suppliers
                        where s.CompanyName == check
                        select s);

            if (item.Count() != 0)
            {
                MessageBox.Show("Mã đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isEmptyTxt())
                {
                    supplier = new Supplier(); // Fix Suppliers
                    supplier.CompanyName = txtSupName.Text;

                    db.Suppliers.Add(supplier); // Fix Suppliers
                    db.SaveChanges();
                    MessageBox.Show("Insert successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                if (isEmptyTxt())
                {
                    supplier = db.Suppliers.Find(SupplierID); // Fix Suppliers

                    supplier.CompanyName = txtSupName.Text;

                    db.SaveChanges();
                    MessageBox.Show("Update successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMainProgram.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (var item in dgvMainProgram.Rows)
                    {
                        DataGridViewRow rows = item as DataGridViewRow;
                        if (rows.Selected)
                        {
                            int supID = Int32.Parse(rows.Cells[0].Value.ToString());
                            var supplier = db.Suppliers.FirstOrDefault(s => s.SupplierID == supID); // Fix Suppliers
                            if (supplier != null)
                            {
                                db.Suppliers.Remove(supplier); // Fix Suppliers
                                db.SaveChanges();
                            }
                        }
                    }
                    MessageBox.Show("Delete successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = (from s in db.Suppliers select s).Count(); // Fix Suppleris

            MessageBox.Show("Total item: " + count.ToString());
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (text != "")
            {
                dgvMainProgram.DataSource = null;
                dgvMainProgram.DataSource = (from s in db.Suppliers             // Fix Suppliers
                                             where s.CompanyName.Contains(text)
                                             select s).ToList();

                dgvMainProgram.Columns["Products"].Visible = false;
            }
            else
            {
                LoadData();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextBox.Clear(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
