using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleEntites
{
    public partial class Form1 : Form
    {
        DAO dao = new DAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basiccsharpDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.basiccsharpDataSet.SinhVien);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.mssv = "DE130149";
            sv.hoten = "Test Add";
            sv.malop = "SE1402";
            if (dao.Insert(sv))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("FAIL");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.mssv = "DE130146";
            sv.hoten = "Test UPDATE";
            sv.malop = "SE1402";
            if (dao.Update(sv))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("FAIL");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.mssv = "DE130147";
            if (dao.Delete(sv))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("FAIL");
            }
        }
    }
}
