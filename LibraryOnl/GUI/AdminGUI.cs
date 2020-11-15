using LibraryOnl.DAO;
using LibraryOnl.DTO;
using LibraryOnl.Service;
using LibraryOnl.Utils;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using PagedList;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace LibraryOnl.GUI
{
    public partial class AdminGUI : Form
    {
        private readonly IBookService bookService = Singleton<BookService>.GetInstance;
        private readonly IUserService userService = Singleton<UserService>.GetInstance;
        private readonly ICategoryService categoryService = Singleton<CategoryService>.GetInstance;
        private int pageNumber = 1;
        private IPagedList<book> listBook;
        private int BookID = -1;
        private int CategoryID = -1;
        private string strPath = "";
        private Byte[] ImgByte;

        public AdminGUI()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            txtFullName.Text = MyUser.Fullname;
            DrawCriclePictureBoxAvatar();
            picAvatar.Image = Image.FromStream(new MemoryStream((byte[])MyUser.Avatar));

        }
        public async Task<IPagedList<book>> GetPageListBook(int pageNumber = 1, int pageSize = 5)
        {
            return await Task.Factory.StartNew(() =>
            {
                using (BookEntities db = new BookEntities())
                {
                    return db.books.OrderBy(p => p.id).ToPagedList(pageNumber, pageSize);
                }
            });
        }
        private void showDataBook()
        {
            DataTable dt = bookService.FindAll();
            dgvBook.DataSource = dt;
        }
        private void showDataUser()
        {
            DataTable dt = userService.FindAll();
            dgvUser.DataSource = dt;
        }

        private void AdminGUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Book Management
        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                BookID = Int32.Parse(dgvBook.Rows[index].Cells[0].Value.ToString());
                txtTitle.Text = dgvBook.Rows[index].Cells[1].Value.ToString();
                txtContent.Text = dgvBook.Rows[index].Cells[2].Value.ToString();
                cbbCategory.SelectedValue = dgvBook.Rows[index].Cells[3].Value.ToString();
                lbFileName.Text = "";
                if (dgvBook.Rows[index].Cells[8].Value.ToString() != "")
                {
                    var data = (Byte[])(dgvBook.Rows[index].Cells[8].Value);
                    var stream = new MemoryStream(data);
                    picImage.Image = Image.FromStream(stream);
                    ImgByte = (Byte[])(dgvBook.Rows[index].Cells[8].Value);
                }

            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CheckImgEmptyCreate())
            {
                BookDTO book = new BookDTO();
                book.Title = txtTitle.Text;
                book.Content = txtContent.Text;
                book.CategoryId = Int32.Parse(cbbCategory.SelectedValue.ToString());
                book.images = convertIamgeToBinary();
                book.CreatedBy = MyUser.Username;
                book.CreateDate = System.DateTime.Now;
                if (bookService.Insert(book))
                {
                    MessageBox.Show("Insert Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataPage();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BookID != -1)
            {
                if (CheckImgEmptyUpdate())
                {
                    BookDTO book = new BookDTO();
                    book.ID = BookID;
                    book.Title = txtTitle.Text;
                    book.Content = txtContent.Text;
                    book.CategoryId = Int32.Parse(cbbCategory.SelectedValue.ToString());
                    if (strPath != "")
                    {
                        book.images = convertIamgeToBinary();
                    }
                    else
                    {
                        book.images = ImgByte;
                    }
                    book.ModifiedBy = MyUser.Username;
                    book.ModifiedDate = System.DateTime.Now;
                    if (bookService.Update(book))
                    {
                        MessageBox.Show("Update Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataPage();
                    }
                    else
                        MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You have not selected the item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                long id = BookID;
                if (bookService.Delete(id))
                {
                    MessageBox.Show("Delete Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox.clearTextBox(this);
                    lbFileName.Text = "";
                    picImage.Image = null;
                    LoadDataPage();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (!string.IsNullOrEmpty(text))
            {
                DataTable dt = bookService.Search(text);
                dgvBook.DataSource = dt;

            }
            else
            {
                LoadDataPage();
            }
        }

        private void bntBrowse_Click(object sender, EventArgs e)
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
        // End Book Management


        // Category Management
        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                CategoryID = Int32.Parse(dgvCategory.Rows[index].Cells[0].Value.ToString());
                txtCategoryName.Text = dgvCategory.Rows[index].Cells[1].Value.ToString();
                txtCategoryCode.Text = dgvCategory.Rows[index].Cells[2].Value.ToString();
            }
        }
        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            if (CheckImgEmptyCategory())
            {
                CategoryDTO category = new CategoryDTO();
                category.Name = txtCategoryName.Text;
                category.Code = txtCategoryCode.Text;
                category.CreatedBy = MyUser.Username;
                category.CreateDate = System.DateTime.Now;
                if (categoryService.Insert(category))
                {
                    MessageBox.Show("Insert Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntUpdateCategory_Click(object sender, EventArgs e)
        {
            if (CategoryID != -1)
            {
                if (CheckImgEmptyCategory())
                {
                    CategoryDTO category = new CategoryDTO();
                    category.ID = CategoryID;
                    category.Name = txtCategoryName.Text;
                    category.Code = txtCategoryCode.Text;
                    category.ModifiedBy = MyUser.Username;
                    category.ModifiedDate = System.DateTime.Now;
                    if (categoryService.Update(category))
                    {
                        MessageBox.Show("Update Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                        MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You have not selected the item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                long id = CategoryID;
                if (categoryService.Delete(id))
                {
                    MessageBox.Show("Delete Success", "Sucssess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox.clearTextBox(this);
                    LoadData();
                }
                else
                    MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // End Category Management


        // Convert Image to Binary File
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

        // Check empty textbox
        private bool CheckImgEmptyUpdate()
        {
            if (Validation.CheckEmptyTextbox(txtTitle, "Title can't be null")) return false;
            if (Validation.CheckEmptyTextbox(txtContent, "Content can't be null")) return false;
            //if (Validation.CheckEmptyLabel(lbFileName, "Image can't be null")) return false;
            return true;
        }
        private bool CheckImgEmptyCreate()
        {
            if (Validation.CheckEmptyTextbox(txtTitle, "Title can't be null")) return false;
            if (Validation.CheckEmptyTextbox(txtContent, "Content can't be null")) return false;
            if (Validation.CheckEmptyLabel(lbFileName, "Image can't be null")) return false;
            return true;
        }
        private bool CheckImgEmptyCategory() {
            if (Validation.CheckEmptyTextbox(txtCategoryName, "Name can't be null")) return false;
            if (Validation.CheckEmptyTextbox(txtCategoryCode, "Code can't be null")) return false;
            return true;
        }

        // Load data from database
        private void LoadData()
        {
            this.usersTableAdapter2.Fill(this.readingbookonlineDataSet6.users);
            this.rolesTableAdapter.Fill(this.readingbookonlineDataSet5.roles);
            this.usersTableAdapter1.Fill(this.readingbookonlineDataSet4.users);
            this.usersTableAdapter.Fill(this.readingbookonlineDataSet3.users);
            this.categoryTableAdapter1.Fill(this.readingbookonlineDataSet2.category);
            this.booksTableAdapter.Fill(this.readingbookonlineDataSet1.books);
            this.categoryTableAdapter.Fill(this.readingbookonlineDataSet.category);

            LoadDataPage();
        }

        private async void LoadDataPage()
        {
            listBook = await GetPageListBook();
            btnPrevBook.Enabled = listBook.HasPreviousPage;
            btnNextBook.Enabled = listBook.HasNextPage;
            dgvBook.DataSource = listBook.ToList();
            lbPageBook.Text = string.Format("Page {0}/{1}", pageNumber, listBook.PageCount);
            this.dgvBook.Columns["id"].Visible = false;
            ((DataGridViewImageColumn)dgvBook.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        // Another Function
        private void DrawCriclePictureBoxAvatar()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picAvatar.Width - 3, picAvatar.Height - 3);
            Region rg = new Region(gp);
            picAvatar.Region = rg;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox.clearTextBox(this);
            this.picImage.Image = null;
            this.lbFileName.Text = "";
            this.txtFullName.Text = MyUser.Fullname;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            MyUser.Fullname = "";
            MyUser.Username = "";
            MyUser.Avatar = null;
            this.Close();
            LoginAndSignUpGUI lsu = new LoginAndSignUpGUI();
            lsu.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
            UserGUI userGUI = new UserGUI();
            userGUI.Show();
        }
        private void btnBookManagemnet_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }
        private void btnCategoryManagemnet_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }
        private void btnUserManagemnet_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
        }
        private void btnRoleManagemnet_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 3;
        }
        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            ClearTextBox.clearTextBox(this);
            this.txtFullName.Text = MyUser.Fullname;
        }
        private void AdminGUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.Tab)
            {
                btnHomePage.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.O)
            {
                bntBrowse.PerformClick();
            }
        }

        // ========================================================================================================================================================================
        // ========================================================================================================================================================================
        // None Function
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }
        private void button1_MouseHover(object sender, EventArgs e)
        {

        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }
        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Title_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtUserSearch.Text;
            if (!string.IsNullOrEmpty(text))
            {
                DataTable dt = userService.Search(text);
                dgvUser.DataSource = dt;

            }
            else
            {
                showDataUser();
            }
        }

        private async void btnPrevBook_Click(object sender, EventArgs e)
        {
            if (listBook.HasPreviousPage)
            {
                listBook = await GetPageListBook(--pageNumber);
                btnPrevBook.Enabled = listBook.HasPreviousPage;
                btnNextBook.Enabled = listBook.HasNextPage;
                dgvBook.DataSource = listBook.ToList();
                lbPageBook.Text = string.Format("Page {0}/{1}", pageNumber, listBook.PageCount);
            }
        }

        private async void btnNextBook_Click(object sender, EventArgs e)
        {
            if (listBook.HasNextPage)
            {
                listBook = await GetPageListBook(++pageNumber);
                btnPrevBook.Enabled = listBook.HasPreviousPage;
                btnNextBook.Enabled = listBook.HasNextPage;
                dgvBook.DataSource = listBook.ToList();
                lbPageBook.Text = string.Format("Page {0}/{1}", pageNumber, listBook.PageCount);
            }
        }
    }
}
