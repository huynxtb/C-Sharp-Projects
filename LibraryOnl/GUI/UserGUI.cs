using LibraryOnl.DAO;
using LibraryOnl.Service;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Speech.Synthesis;
using LibraryOnl.Utils;

namespace LibraryOnl.GUI
{
    public partial class UserGUI : Form
    {
        private readonly IBookService bookService = Singleton<BookService>.GetInstance;
        private SpeechSynthesizer speech = new SpeechSynthesizer();
        private int playAndPause = 0;
        public UserGUI()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtFullName.Text = MyUser.Fullname;
            DrawCriclePictureBoxAvatar();
            picAvatar.Image = Image.FromStream(new MemoryStream((byte[])MyUser.Avatar));
            if (MyUser.Role == "ADMIN")
            {
                ResourceManager rm = new ResourceManager("LibraryOnl.Images",
                                         Assembly.GetExecutingAssembly());
                Image img = (System.Drawing.Image)rm.GetObject("btnAdmin_48_px");

                Button admin = new Button
                {
                    Width = 166,
                    Height = 58,
                    Cursor = Cursors.Hand,
                    Text = "         AD Home",
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Crimson,
                    Font = new Font("Century", 12, FontStyle.Bold),
                    BackColor = Color.PeachPuff,
                    FlatStyle = FlatStyle.Flat,
                    Image = img,
                    ImageAlign = ContentAlignment.MiddleLeft,
                };
                admin.MouseClick += new MouseEventHandler((o, a) =>
                 {
                     speech.SpeakAsyncCancelAll();
                     this.Close();
                     AdminGUI adminGUI = new AdminGUI();
                     adminGUI.Show();
                 });
                flpAdmin.Controls.Add(admin);
            }
            btnSpeak.Enabled = false;
            btnStop.Enabled = false;
        }
        private void UserGUI_Load(object sender, EventArgs e)
        {
            DataTable dt = bookService.FindAll();
            ShowListByImage(dt);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (!string.IsNullOrEmpty(text))
            {
                this.flpMain.Controls.Clear();
                DataTable dt = bookService.Search(text);
                ShowListByImage(dt);
            }
            else
            {
                this.flpMain.Controls.Clear();
                DataTable dt = bookService.FindAll();
                ShowListByImage(dt);
            }

            if (this.flpMain.Controls.Count == 0)
            {
                lbNotFound.Text = "Not found \"" + txtSearch.Text + "\"";
            }
            else
            {
                lbNotFound.Text = "";
            }
        }

        private void btnCategoryIT_Click(object sender, EventArgs e)
        {
            this.flpMain.Controls.Clear();
            DataTable dt = bookService.SearchByCategoryId(1L);
            ShowListByImage(dt);

        }

        private void btnCategoryComic_Click(object sender, EventArgs e)
        {
            this.flpMain.Controls.Clear();
            DataTable dt = bookService.SearchByCategoryId(2L);
            ShowListByImage(dt);
        }

        private void btnCategorySeflHelp_Click(object sender, EventArgs e)
        {
            this.flpMain.Controls.Clear();
            DataTable dt = bookService.SearchByCategoryId(3L);
            ShowListByImage(dt);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.flpMain.Controls.Clear();
            DataTable dt = bookService.FindAll();
            ShowListByImage(dt);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int count = flpMain.Controls.Count;
            Console.WriteLine("Total item in flowLayoutPanelMain " + count);
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please input name book!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (count == 0)
                {
                    if (MessageBox.Show("Not found \"" + txtSearch.Text + "\" in the system\nDo you want to search it with Google?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string search = "https://www.google.com/search?q=";
                        Process.Start(search + txtSearch.Text + " book");
                    }
                }
                if (count != 0)
                {
                    if (MessageBox.Show("There are/is " + count + " books found in the system\nDo you still want to search for it with google?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string search = "https://www.google.com/search?q=";
                        Process.Start(search + txtSearch.Text + " book");
                    }
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            speech.SpeakAsyncCancelAll();
            MyUser.Fullname = "";
            MyUser.Username = "";
            MyUser.Avatar = null;
            this.Close();
            LoginAndSignUpGUI lsu = new LoginAndSignUpGUI();
            lsu.Show();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContent.Text))
            {
                btnSpeak.Enabled = false;
                btnStop.Enabled = true;
                speech.SpeakAsync(txtContent.Text);
                speech.Volume = 100;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sách!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContent.Text))
            {
                btnSpeak.Enabled = true;
                btnStop.Enabled = false;
                speech.SpeakAsyncCancelAll();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sách!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DrawCriclePictureBoxAvatar()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picAvatar.Width - 3, picAvatar.Height - 3);
            Region rg = new Region(gp);
            picAvatar.Region = rg;
        }

        private void ShowListByImage(DataTable dt)
        {
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    PictureBox pictureBoxImage = new PictureBox
                    {
                        Width = 150,
                        Height = 150,
                        BorderStyle = BorderStyle.Fixed3D,
                        Padding = new System.Windows.Forms.Padding(10),
                        Image = Image.FromStream(new MemoryStream((byte[])item[8])),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Cursor = Cursors.Hand,

                    };

                    pictureBoxImage.MouseClick += new MouseEventHandler((o, a) =>
                    {
                        txtContent.Text = item["content"].ToString();
                        txtTitleChioce.Text = item["title"].ToString();
                        picBook.Image = pictureBoxImage.Image;
                        picBook.SizeMode = PictureBoxSizeMode.StretchImage;
                    });

                    flpMain.Controls.Add(pictureBoxImage);
                }
            }
        }

        private void UserGUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyUser.Role == "ADMIN")
            {
                if (e.Control == true && e.KeyCode == Keys.Tab)
                {
                    AdminGUI gui = new AdminGUI();
                    this.Close();
                    gui.Show();
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
            else if (e.KeyCode == Keys.F1)
            {
                if (playAndPause == 0)
                {
                    btnSpeak.PerformClick();
                    playAndPause = 1;
                }
                else if (playAndPause == 1)
                {
                    btnStop.PerformClick();
                    playAndPause = 0;
                }

            }
        }

        //private void DisplayImageToFlowLayoutTEST()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {

        //        PictureBox imageControl = new PictureBox();
        //        imageControl.Width = 150;
        //        imageControl.Height = 150;
        //        Bitmap image = new Bitmap("D:\\Photos\\HT\\1.jpg");
        //        imageControl.Image = (Image)image;
        //        imageControl.SizeMode = PictureBoxSizeMode.StretchImage;
        //        flowLayoutPanelMain.Controls.Add(imageControl);
        //    }
        //}
        // End Main Function

        //=======================================================================================================================================================================
        //=======================================================================================================================================================================
        // None Function

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            btnSpeak.Enabled = true;
            btnStop.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
