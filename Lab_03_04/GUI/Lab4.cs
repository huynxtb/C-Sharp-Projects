using Lab_03_04.DAO;
using Lab_03_04.DTO.lab4;
using Lab_03_04.Utils;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PagedList;
using System.Threading.Tasks;
using System.Linq;

namespace Lab_03_04
{
    public partial class Lab4 : Form
    {
        #region variable
        private int SupplierID;
        private int ProductID;
        private int CategoryID;
        private int Discontinued;
        private string strPath = "";
        private string url = "";
        private Byte[] ImgByte;
        private int pageNumber1 = 1;
        private int pageNumber2 = 1;
        private int pageNumber3 = 1;
        private IPagedList<Supplier> listSup;
        private IPagedList<Product> listProc;
        private IPagedList<Category> listCate;
        #endregion

        public Lab4()
        {
            InitializeComponent();
            this.CenterToScreen();
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #region methods
        public async Task<IPagedList<Supplier>> GetPageListSupplier(int pageNumber = 1, int pageSize = 10)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (NorthwindEntities db = new NorthwindEntities())
                {
                    return db.Suppliers.OrderBy(p => p.SupplierID).ToPagedList(pageNumber, pageSize);
                }
            });
        }
        public async Task<IPagedList<Product>> GetPageListProduct(int pageNumber = 1, int pageSize = 10)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (ProductEntities db = new ProductEntities())
                {
                    return db.Products.OrderBy(p => p.ProductID).ToPagedList(pageNumber, pageSize);
                }
            });
        }
        public async Task<IPagedList<Category>> GetPageListCategory(int pageNumber = 1, int pageSize = 2)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (CategoryEntities db = new CategoryEntities())
                {
                    return db.Categories.OrderBy(p => p.CategoryID).ToPagedList(pageNumber, pageSize);
                }
            });
        }
        private void btnChoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChoice frm = new frmChoice();
            frm.Show();
        }
        private bool IsEmptySupplier ()
        {
            if (Validation.IsEmptyString(txtSupName, "Company name can't be null")) return false;
            if (Validation.IsEmptyString(txtSupContract, "Contract name can't be null")) return false;
            if (Validation.IsEmptyString(txtSupTitle, "Title can't be null")) return false;
            if (Validation.IsEmptyString(txtSupAddress, "Address can't be null")) return false;
            if (Validation.IsEmptyString(txtSupPhone, "Phone can't be null")) return false;
            if (Validation.IsEmptyString(txtSupFax, "Fax can't be null")) return false;
            if (Validation.IsEmptyString(txtSupCity, "City can't be null")) return false;
            if (Validation.IsEmptyString(txtSupRegion, "Region can't be null")) return false;
            if (Validation.IsEmptyString(txtSupPostcal, "Postcal can't be null")) return false;
            if (Validation.IsEmptyString(txtSupCountry, "Country can't be null")) return false;
            return true;
        }
        private bool IsEmptyProduct()
        {
            if (Validation.IsEmptyString(txtProName, "Name can't be null")) return false;
            if (Validation.IsEmptyString(txtProQuarity, "Quarity can't be null")) return false;
            if (Validation.IsEmptyString(txtProPrice, "Price can't be null")) return false;
            if (Validation.IsEmptyString(txtProStock, "Stock can't be null")) return false;
            if (Validation.IsEmptyString(txtProOrder, "Order can't be null")) return false;
            if (Validation.IsEmptyString(txtProReorder, "Reorder can't be null")) return false;
            return true;
        }
        private bool IsEmptyCategory()
        {
            if (Validation.IsEmptyString(txtCateName, "Name can't be null")) return false;
            if (Validation.IsEmptyString(txtCateDescription, "Description can't be null")) return false;
            if (string.IsNullOrEmpty(lbFileName.Text))
            {
                MessageBox.Show("Picture can't be null", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private Byte[] convertIamgeToBinary()
        {
            if (strPath == "")
            {
                if (ImgByte.Length != 0)
                {
                    ImgByte = new byte[] { };
                }
            }
            else
            {
                Image img = new Bitmap(strPath);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ImgByte = ms.ToArray();
            }
            return ImgByte;
        }
        private async void LoadData()
        {
            // TODO: This line of code loads data into the 'northwindDataSet4.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter1.Fill(this.northwindDataSet4.Categories);
            // TODO: This line of code loads data into the 'northwindDataSet3.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwindDataSet3.Categories);
            // TODO: This line of code loads data into the 'northwindDataSet2.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter1.Fill(this.northwindDataSet2.Suppliers);
            // TODO: This line of code loads data into the 'northwindDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet1.Products);
            // TODO: This line of code loads data into the 'northwindDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);

            // list categories
            listCate = await GetPageListCategory();
            btnPrevCate.Enabled = listCate.HasPreviousPage;
            btnNextCate.Enabled = listCate.HasNextPage;
            dgvCategories.DataSource = listCate.ToList();
            lbPageCate.Text = string.Format("Page {0}/{1}", pageNumber3, listCate.PageCount);

            // list products
            listProc = await GetPageListProduct();
            btnPrevPro.Enabled = listProc.HasPreviousPage;
            btnNextPro.Enabled = listProc.HasNextPage;
            dgvProducts.DataSource = listProc.ToList();
            lbPagePro.Text = string.Format("Page {0}/{1}", pageNumber2, listProc.PageCount);

            // list suppleris
            listSup = await GetPageListSupplier();
            btnPrevSup.Enabled = listSup.HasPreviousPage;
            btnNextSup.Enabled = listSup.HasNextPage;
            dgvSuppliers.DataSource = listSup.ToList();
            lbPagingSup.Text = string.Format("Page {0}/{1}", pageNumber1, listSup.PageCount);

            ((DataGridViewImageColumn)dgvCategories.Columns[3]).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        #endregion

        #region events click
        private void Lab4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

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
                string str = txtSupHomePage.Text;
                string[] strlist = str.Split(' ');

                foreach (string item in strlist)
                {
                    if (item.Contains("http"))
                    {
                        url = item;
                    }
                }
            }
            Console.WriteLine(url);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ProductID = Int32.Parse(dgvProducts.Rows[index].Cells[0].Value.ToString());
                txtProName.Text = dgvProducts.Rows[index].Cells[1].Value.ToString();
                cbbSupplier.SelectedValue = dgvProducts.Rows[index].Cells[2].Value.ToString();
                cbbCategory.SelectedValue = dgvProducts.Rows[index].Cells[3].Value.ToString();
                txtProQuarity.Text = dgvProducts.Rows[index].Cells[4].Value.ToString();
                txtProPrice.Text = dgvProducts.Rows[index].Cells[5].Value.ToString();
                txtProStock.Text = dgvProducts.Rows[index].Cells[6].Value.ToString();
                txtProOrder.Text = dgvProducts.Rows[index].Cells[7].Value.ToString();
                txtProReorder.Text = dgvProducts.Rows[index].Cells[8].Value.ToString();
                //txtProDiscontinued.Text = dgvProducts.Rows[index].Cells[9].Value.ToString();

                if (Boolean.Parse(dgvProducts.Rows[index].Cells[9].Value.ToString()) == true)
                {
                    rbtTrue.Checked = true;
                    rbtFalse.Checked = false;
                }
                if (Boolean.Parse(dgvProducts.Rows[index].Cells[9].Value.ToString()) == false)
                {
                    rbtTrue.Checked = false;
                    rbtFalse.Checked = true;
                }
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                CategoryID = Int32.Parse(dgvCategories.Rows[index].Cells[0].Value.ToString());
                txtCateName.Text = dgvCategories.Rows[index].Cells[1].Value.ToString();
                txtCateDescription.Text = dgvCategories.Rows[index].Cells[2].Value.ToString();
                lbFileName.Text = "";
                if (dgvCategories.Rows[index].Cells[3].Value.ToString() != "")
                {
                    byte[] data = (byte[])(dgvCategories.CurrentRow.Cells[3].Value);
                    MemoryStream stream = new MemoryStream(data);
                    picImage.Image = Image.FromStream(stream);
                }
            }
        }

        private void btnProAdd_Click(object sender, EventArgs e)
        {
            if (rbtTrue.Checked)
            {
                Discontinued = 0;
            }
            if (rbtFalse.Checked)
            {
                Discontinued = 1;
            }

            if (IsEmptyProduct())
            {
                ProductDTO dto = new ProductDTO();
                dto.ProductName = txtProName.Text;
                dto.SupplierID = Int32.Parse(cbbSupplier.SelectedValue.ToString());
                dto.CategoryID = Int32.Parse(cbbCategory.SelectedValue.ToString());
                dto.Quarity = txtProQuarity.Text;
                dto.Price = float.Parse(txtProPrice.Text);
                dto.Stock = Int32.Parse(txtProStock.Text);
                dto.Order = Int32.Parse(txtProOrder.Text);
                dto.Reorder = Int32.Parse(txtProReorder.Text);
                dto.Discontinued = Discontinued;

                if (ProductDAO.GetInstance.Insert(dto))
                {
                    MessageBox.Show("Add success", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images (.jpg; .jpeg; .png)|*.jpg; *.jpeg; *.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                strPath = op.FileName;
                picImage.Image = new Bitmap(strPath);
                picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                lbFileName.Text = System.IO.Path.GetFileName(strPath);
            }
        }

        private void btnSupUpdate_Click(object sender, EventArgs e)
        {
            if (IsEmptySupplier())
            {
                SupplierDTO dto = new SupplierDTO();
                dto.ID = SupplierID;
                dto.CompanyName = txtSupName.Text;
                dto.ContactName = txtSupContract.Text;
                dto.ContactTitle = txtSupTitle.Text;
                dto.Address = txtSupAddress.Text;
                dto.Phone = txtSupPhone.Text;
                dto.Fax = txtSupFax.Text;
                dto.City = txtSupCity.Text;
                dto.Region = txtSupRegion.Text;
                dto.PostalCode = txtSupPostcal.Text;
                dto.Country = txtSupCountry.Text;
                dto.HomePage = txtSupHomePage.Text;

                if (SupplierDAO.GetInstance.Update(dto))
                {
                    MessageBox.Show("Update success", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSupAdd_Click(object sender, EventArgs e)
        {
            if (IsEmptySupplier())
            {
                SupplierDTO dto = new SupplierDTO();
                dto.CompanyName = txtSupName.Text;
                dto.ContactName = txtSupContract.Text;
                dto.ContactTitle = txtSupTitle.Text;
                dto.Address = txtSupAddress.Text;
                dto.Phone = txtSupPhone.Text;
                dto.Fax = txtSupFax.Text;
                dto.City = txtSupCity.Text;
                dto.Region = txtSupRegion.Text;
                dto.PostalCode = txtSupPostcal.Text;
                dto.Country = txtSupCountry.Text;
                dto.HomePage = txtSupHomePage.Text;

                if (SupplierDAO.GetInstance.Insert(dto))
                {
                    MessageBox.Show("Insert success", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSupDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = SupplierID;
                if (SupplierDAO.GetInstance.Delete(id))
                {
                    MessageBox.Show("Delete Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox.Clear(this);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupReset_Click(object sender, EventArgs e)
        {
            ClearTextBox.Clear(this);
        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            if (rbtTrue.Checked)
            {
                Discontinued = 0;
            }
            if (rbtFalse.Checked)
            {
                Discontinued = 1;
            }

            if (IsEmptyProduct())
            {
                ProductDTO dto = new ProductDTO();
                dto.ID = ProductID;
                dto.ProductName = txtProName.Text;
                dto.SupplierID = Int32.Parse(cbbSupplier.SelectedValue.ToString());
                dto.CategoryID = Int32.Parse(cbbCategory.SelectedValue.ToString());
                dto.Quarity = txtProQuarity.Text;
                dto.Price = float.Parse(txtProPrice.Text);
                dto.Stock = Int32.Parse(txtProStock.Text);
                dto.Order = Int32.Parse(txtProOrder.Text);
                dto.Reorder = Int32.Parse(txtProReorder.Text);
                dto.Discontinued = Discontinued;

                if (ProductDAO.GetInstance.Update(dto))
                {
                    MessageBox.Show("Update success", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = ProductID;
                if (ProductDAO.GetInstance.Delete(id))
                {
                    MessageBox.Show("Delete Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox.Clear(this);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProReset_Click(object sender, EventArgs e)
        {
            ClearTextBox.Clear(this);
        }

        private void btnCateAdd_Click(object sender, EventArgs e)
        {
            if (IsEmptyCategory())
            {
                CategoryDTO dto = new CategoryDTO();
                dto.CateName = txtCateName.Text;
                dto.Description = txtCateDescription.Text;
                dto.Pricture = convertIamgeToBinary();
                if (CategoryDAO.GetInstance.Insert(dto))
                {
                    MessageBox.Show("Insert Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox.Clear(this);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        private void btnCateUpdate_Click(object sender, EventArgs e)
        {
            if (IsEmptyCategory())
            {
                CategoryDTO dto = new CategoryDTO();
                dto.ID = CategoryID;
                dto.CateName = txtCateName.Text;
                dto.Description = txtCateDescription.Text;
                dto.Pricture = convertIamgeToBinary();
                if (CategoryDAO.GetInstance.Update(dto))
                {
                    MessageBox.Show("Update Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox.Clear(this);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        private void btnCateDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = CategoryID;
                if (CategoryDAO.GetInstance.Delete(id))
                {
                    MessageBox.Show("Delete Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox.Clear(this);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCateReset_Click(object sender, EventArgs e)
        {
            ClearTextBox.Clear(this);
            lbFileName.Text = "";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (url != "")
            {
                if (MessageBox.Show("Do you want to  open home page with google chrome?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string link = url;
                    Process.Start(link);
                }
            }
            else
            {
                MessageBox.Show("Not found url home page!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchSup_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearchSup.Text;
            if (text != "")
            {
                DataTable dt = SupplierDAO.GetInstance.SearchByCompanyName(text);
                dgvSuppliers.DataSource = dt;
            }
            else
            {
                LoadData();
            }
        }

        private void txtSearchPro_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearchPro.Text;
            if (text != "")
            {
                DataTable dt = ProductDAO.GetInstance.SearchByProductName(text);
                dgvProducts.DataSource = dt;
            }
            else 
            { 
                LoadData(); 
            }
           
        }

        private void txtSearchCate_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearchCate.Text;
            if (text != "")
            {
                DataTable dt = CategoryDAO.GetInstance.SearchByCategoryName(text);
                dgvCategories.DataSource = dt;
            }
            else
            {
                LoadData();
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

        private void txtProStock_TextChanged(object sender, EventArgs e)
        {
            RegexNumber(txtProStock, "Stock must be digit");
        }

        private void txtProOrder_TextChanged(object sender, EventArgs e)
        {
            RegexNumber(txtProOrder, "Order must be digit");
        }

        private void txtProReorder_TextChanged(object sender, EventArgs e)
        {
            RegexNumber(txtProReorder, "Reorder must be digit");
        }

        private async void btnPrevSup_Click(object sender, EventArgs e)
        {
            if (listSup.HasPreviousPage)
            {
                listSup = await GetPageListSupplier(--pageNumber1);
                btnPrevSup.Enabled = listSup.HasPreviousPage;
                btnNextSup.Enabled = listSup.HasNextPage;
                dgvSuppliers.DataSource = listSup.ToList();
                lbPagingSup.Text = string.Format("Page {0}/{1}", pageNumber1, listSup.PageCount);
            }
        }

        private async void btnNextSup_Click(object sender, EventArgs e)
        {
            if (listSup.HasNextPage)
            {
                listSup = await GetPageListSupplier(++pageNumber1);
                btnPrevSup.Enabled = listSup.HasPreviousPage;
                btnNextSup.Enabled = listSup.HasNextPage;
                dgvSuppliers.DataSource = listSup.ToList();
                lbPagingSup.Text = string.Format("Page {0}/{1}", pageNumber1, listSup.PageCount);
            }
        }

        private async void btnPrevPro_Click(object sender, EventArgs e)
        {
            if (listProc.HasPreviousPage)
            {
                listProc = await GetPageListProduct(--pageNumber2);
                btnPrevPro.Enabled = listProc.HasPreviousPage;
                btnNextPro.Enabled = listProc.HasNextPage;
                dgvProducts.DataSource = listProc.ToList();
                lbPagePro.Text = string.Format("Page {0}/{1}", pageNumber2, listProc.PageCount);
            }
        }

        private async void btnNextPro_Click(object sender, EventArgs e)
        {
            if (listProc.HasNextPage)
            {
                listProc = await GetPageListProduct(++pageNumber2);
                btnPrevPro.Enabled = listProc.HasPreviousPage;
                btnNextPro.Enabled = listProc.HasNextPage;
                dgvProducts.DataSource = listProc.ToList();
                lbPagePro.Text = string.Format("Page {0}/{1}", pageNumber2, listProc.PageCount);
            }
        }

        private async void btnPrevCate_Click(object sender, EventArgs e)
        {
            if (listCate.HasPreviousPage)
            {
                listCate = await GetPageListCategory(--pageNumber3);
                btnPrevCate.Enabled = listCate.HasPreviousPage;
                btnNextCate.Enabled = listCate.HasNextPage;
                dgvCategories.DataSource = listCate.ToList();
                lbPageCate.Text = string.Format("Page {0}/{1}", pageNumber3, listCate.PageCount);
            }
        }

        private async void btnNextCate_Click(object sender, EventArgs e)
        {
            if (listCate.HasNextPage)
            {
                listCate = await GetPageListCategory(++pageNumber3);
                btnPrevCate.Enabled = listCate.HasPreviousPage;
                btnNextCate.Enabled = listCate.HasNextPage;
                dgvCategories.DataSource = listCate.ToList();
                lbPageCate.Text = string.Format("Page {0}/{1}", pageNumber3, listCate.PageCount);
            }
        }
        #endregion

        private void txtSupPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
