using LibraryOnl.Constant;
using LibraryOnl.DAO;
using LibraryOnl.DTO;
using LibraryOnl.Service;
using LibraryOnl.Utils;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryOnl.GUI
{
    public partial class LoginAndSignUpGUI : Form
    {
        private readonly IUserService userService = Singleton<UserService>.GetInstance;
        private string strPath = "";
        private Byte[] ImgByte;
        public LoginAndSignUpGUI()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (chkPassword2.Checked)
                txtPasswordSginUp.UseSystemPasswordChar = true;
        }
        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            if (checkTextBoxLogin())
            {
                UserDTO user = userService.FindUserByUsername(txtUsernameLogin.Text, txtPasswordLogin.Text, SystemConstant.IS_ACTIVE);

                if (user != null)
                {
                    MyUser.Fullname = user.Fullname;
                    MyUser.Username = user.Username;
                    MyUser.Avatar = user.Avatar;
                    MyUser.Role = user.role.code;
                    this.Hide();
                    if (user.role.code == "ADMIN")
                    {
                        AdminGUI adminGUI = new AdminGUI();
                        adminGUI.Show();
                    }
                    else if (user.role.code == "USER")
                    {
                        UserGUI userGUI = new UserGUI();
                        userGUI.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Password or username invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
        private void btnSubmitSignUp_Click(object sender, EventArgs e)
        {
            if (checkTextBoxSignUp())
            {
                bool check = userService.IsExistedBy(txtUsernameSginUp.Text);

                if (!check)
                {
                    UserDTO user = new UserDTO();
                    user.Username = txtUsernameSginUp.Text;
                    user.Password = SecurityUtil.Encrypt(txtPasswordSginUp.Text);
                    user.Fullname = txtFullnameSignUp.Text;
                    user.Email = txtEmailSignUp.Text;
                    user.Status = SystemConstant.IS_ACTIVE;
                    user.RoleId = SystemConstant.ROLE_ID_USER;
                    user.Avatar = convertIamgeToBinary();
                    user.CreatedBy = txtUsernameSginUp.Text;
                    user.CreateDate = System.DateTime.Now;
                    if (userService.Insert(user))
                    {
                        if (MessageBox.Show("Sign Up Sucssess. Go to login", "Sucssess", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            tabControlLoginAndSignUp.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username is already in system!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //OpenImageFile.open(pictureBoxAvatar, txtFileName, strPath);
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images (.jpg; .jpeg; .png)|*.jpg; *.jpeg; *.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                strPath = op.FileName;
                picAvatar.Image = new Bitmap(strPath);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;

                    lbFilename.Text = System.IO.Path.GetFileName(strPath);
                
            }
        }
        // Convert Image To Bibnary File
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
        private bool checkTextBoxLogin()
        {
            if (Validation.CheckEmptyTextbox(txtUsernameLogin, "Username can't be null")) return false;
            if (Validation.CheckEmptyTextbox(txtPasswordLogin, "Password can't be null")) return false;
            return true;
        }
        private bool checkTextBoxSignUp()
        {
            if (Validation.CheckEmptyTextbox(txtUsernameSginUp, "Username can't be null")) return false;
            if (Validation.CheckEmptyTextbox(txtPasswordSginUp, "Password can't be null")) return false;
            if (Validation.CheckEmptyTextbox(txtFullnameSignUp, "Fullname can't be null")) return false;
            if (Validation.CheckEmptyTextbox(txtEmailSignUp, "Email can't be null")) return false;
            if (!Validation.ValidEmail(txtEmailSignUp, "Incorect format email")) return false;
            if (Validation.CheckEmptyLabel(lbFilename, "Avatar can't be null")) return false;
            return true;
        }
        // End Check empty textbox 
        private void chkPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword2.Checked)
                txtPasswordSginUp.UseSystemPasswordChar = true;
            else
                txtPasswordSginUp.UseSystemPasswordChar = false;
        }
        private void btnTabSignUp_Click(object sender, EventArgs e)
        {
            tabControlLoginAndSignUp.SelectedIndex = 1;
        }
        private void btnTabLogin_Click(object sender, EventArgs e)
        {
            tabControlLoginAndSignUp.SelectedIndex = 0;
        }



        //=================================================================================================================================
        //=================================================================================================================================
        // None Function
        private void chkPassword1_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkPassword1.Checked)
            //    txtPasswordLogin.UseSystemPasswordChar = true;
            //else
            //    txtPasswordLogin.UseSystemPasswordChar = false;

        }
        private void txtPasswordSginUp_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginAndSignUpGUI_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabControlLoginAndSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmitLogin.PerformClick();
                btnSubmitSignUp.PerformClick();
            }
            else if (e.Control == true && e.KeyCode == Keys.O)
            {
                btnBrowse.PerformClick();
            }
        }

        private void panel1_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsernameSginUp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

        
