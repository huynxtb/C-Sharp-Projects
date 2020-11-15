using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        private NorthwindEntities db = new NorthwindEntities();
        private Supplier supplier;
        private int SupplierID;
        public Form1()
        {
            InitializeComponent();

        }

        #region methods
        private void LoadData()
        {
            dgvSuppliers.DataSource = null;
            var list = from s in db.Suppliers select s;
            dgvSuppliers.DataSource = list.ToList();
            dgvSuppliers.Columns["Products"].Visible = false;
        }
        #endregion
        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                SupplierID = Int32.Parse(dgvSuppliers.Rows[index].Cells[0].Value.ToString());
                txtSupName.Text = dgvSuppliers.Rows[index].Cells[1].Value.ToString();
                txtSupContract.Text = dgvSuppliers.Rows[index].Cells[2].Value.ToString();
                txtSupTitle.Text = dgvSuppliers.Rows[index].Cells[3].Value.ToString();
                txtSupAddress.Text = dgvSuppliers.Rows[index].Cells[4].Value.ToString();
                txtSupCity.Text = dgvSuppliers.Rows[index].Cells[5].Value.ToString();
                txtSupRegion.Text = dgvSuppliers.Rows[index].Cells[6].Value.ToString();
                txtSupPostcal.Text = dgvSuppliers.Rows[index].Cells[7].Value.ToString();
                txtSupCountry.Text = dgvSuppliers.Rows[index].Cells[8].Value.ToString();
                txtSupPhone.Text = dgvSuppliers.Rows[index].Cells[9].Value.ToString();
                txtSupFax.Text = dgvSuppliers.Rows[index].Cells[10].Value.ToString();
                txtSupHomePage.Text = dgvSuppliers.Rows[index].Cells[11].Value.ToString();
            }
        }
        private void btnSupAdd_Click(object sender, EventArgs e)
        {
            supplier = new Supplier();
            supplier.CompanyName = txtSupName.Text;
            supplier.ContactName = txtSupContract.Text;
            supplier.ContactTitle = txtSupTitle.Text;
            supplier.Address = txtSupAddress.Text;
            supplier.Phone = txtSupPhone.Text;
            supplier.Fax = txtSupFax.Text;
            supplier.City = txtSupCity.Text;
            supplier.Region = txtSupRegion.Text;
            supplier.PostalCode = txtSupPostcal.Text;
            supplier.Country = txtSupCountry.Text;
            supplier.HomePage = txtSupHomePage.Text;
            db.Suppliers.Add(supplier);
            db.SaveChanges();
            MessageBox.Show("Insert successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
        private void btnSupUpdate_Click(object sender, EventArgs e)
        {
            supplier = db.Suppliers.Find(SupplierID);
            supplier.CompanyName = txtSupName.Text;
            supplier.ContactName = txtSupContract.Text;
            supplier.ContactTitle = txtSupTitle.Text;
            supplier.Address = txtSupAddress.Text;
            supplier.Phone = txtSupPhone.Text;
            supplier.Fax = txtSupFax.Text;
            supplier.City = txtSupCity.Text;
            supplier.Region = txtSupRegion.Text;
            supplier.PostalCode = txtSupPostcal.Text;
            supplier.Country = txtSupCountry.Text;
            supplier.HomePage = txtSupHomePage.Text;
            db.SaveChanges();
            MessageBox.Show("Update successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
        private void btnSupDelete_Click(object sender, EventArgs e)
        {

            foreach (var item in dgvSuppliers.Rows)
            {
                DataGridViewRow rows = item as DataGridViewRow;
                if (rows.Selected)
                {
                    int supID = Int32.Parse(rows.Cells[0].Value.ToString());
                    var supplier = db.Suppliers.FirstOrDefault(s => s.SupplierID == supID);
                    if (supplier != null)
                    {
                        db.Suppliers.Remove(supplier);
                        db.SaveChanges();
                    }
                }
            }
            MessageBox.Show("Delete successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();

        }
        private void btnSupReset_Click(object sender, EventArgs e)
        {
            ClearTextBox.Clear(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnChoice_Click(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
