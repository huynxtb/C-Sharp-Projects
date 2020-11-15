namespace LibraryOnl.GUI
{
    partial class LoginAndSignUpGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlLoginAndSignUp = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.btnTabSignUp = new System.Windows.Forms.Button();
            this.btnSubmitLogin = new System.Windows.Forms.Button();
            this.tabSignup = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtEmailSignUp = new System.Windows.Forms.TextBox();
            this.lbFilename = new System.Windows.Forms.Label();
            this.btnTabLogin = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmitSignUp = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.chkPassword2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsernameSginUp = new System.Windows.Forms.TextBox();
            this.txtPasswordSginUp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullnameSignUp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlLoginAndSignUp.SuspendLayout();
            this.tabLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.tabSignup.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlLoginAndSignUp
            // 
            this.tabControlLoginAndSignUp.CausesValidation = false;
            this.tabControlLoginAndSignUp.Controls.Add(this.tabLogin);
            this.tabControlLoginAndSignUp.Controls.Add(this.tabSignup);
            this.tabControlLoginAndSignUp.Location = new System.Drawing.Point(1, 6);
            this.tabControlLoginAndSignUp.Name = "tabControlLoginAndSignUp";
            this.tabControlLoginAndSignUp.SelectedIndex = 0;
            this.tabControlLoginAndSignUp.Size = new System.Drawing.Size(1120, 645);
            this.tabControlLoginAndSignUp.TabIndex = 0;
            this.tabControlLoginAndSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControlLoginAndSignUp_KeyDown);
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.Moccasin;
            this.tabLogin.Controls.Add(this.button1);
            this.tabLogin.Controls.Add(this.picLogin);
            this.tabLogin.Controls.Add(this.label8);
            this.tabLogin.Controls.Add(this.label3);
            this.tabLogin.Controls.Add(this.txtPasswordLogin);
            this.tabLogin.Controls.Add(this.txtUsernameLogin);
            this.tabLogin.Controls.Add(this.btnTabSignUp);
            this.tabLogin.Controls.Add(this.btnSubmitLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1112, 619);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::LibraryOnl.database.exit_icon_32;
            this.button1.Location = new System.Drawing.Point(1081, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 29);
            this.button1.TabIndex = 16;
            this.toolTip1.SetToolTip(this.button1, "Exit");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picLogin
            // 
            this.picLogin.Image = global::LibraryOnl.database.blog_wp_login;
            this.picLogin.Location = new System.Drawing.Point(310, 70);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(535, 180);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 15;
            this.picLogin.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(432, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(432, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(436, 393);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(304, 26);
            this.txtPasswordLogin.TabIndex = 11;
            this.txtPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameLogin.Location = new System.Drawing.Point(436, 300);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(304, 26);
            this.txtUsernameLogin.TabIndex = 10;
            this.txtUsernameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTabSignUp
            // 
            this.btnTabSignUp.BackColor = System.Drawing.Color.Lime;
            this.btnTabSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabSignUp.Location = new System.Drawing.Point(615, 463);
            this.btnTabSignUp.Name = "btnTabSignUp";
            this.btnTabSignUp.Size = new System.Drawing.Size(128, 69);
            this.btnTabSignUp.TabIndex = 8;
            this.btnTabSignUp.Text = "Sign Up";
            this.btnTabSignUp.UseVisualStyleBackColor = false;
            this.btnTabSignUp.Click += new System.EventHandler(this.btnTabSignUp_Click);
            // 
            // btnSubmitLogin
            // 
            this.btnSubmitLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSubmitLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitLogin.Location = new System.Drawing.Point(436, 463);
            this.btnSubmitLogin.Name = "btnSubmitLogin";
            this.btnSubmitLogin.Size = new System.Drawing.Size(128, 69);
            this.btnSubmitLogin.TabIndex = 7;
            this.btnSubmitLogin.Text = "Login";
            this.btnSubmitLogin.UseVisualStyleBackColor = false;
            this.btnSubmitLogin.Click += new System.EventHandler(this.btnSubmitLogin_Click);
            // 
            // tabSignup
            // 
            this.tabSignup.BackColor = System.Drawing.Color.Transparent;
            this.tabSignup.Controls.Add(this.panel1);
            this.tabSignup.Controls.Add(this.panel2);
            this.tabSignup.Location = new System.Drawing.Point(4, 22);
            this.tabSignup.Name = "tabSignup";
            this.tabSignup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignup.Size = new System.Drawing.Size(1112, 619);
            this.tabSignup.TabIndex = 1;
            this.tabSignup.Text = "Sign Up";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtEmailSignUp);
            this.panel1.Controls.Add(this.lbFilename);
            this.panel1.Controls.Add(this.btnTabLogin);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.btnSubmitSignUp);
            this.panel1.Controls.Add(this.picAvatar);
            this.panel1.Controls.Add(this.chkPassword2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUsernameSginUp);
            this.panel1.Controls.Add(this.txtPasswordSginUp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFullnameSignUp);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 613);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Enter += new System.EventHandler(this.panel1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::LibraryOnl.database.exit_icon_32;
            this.button2.Location = new System.Drawing.Point(1078, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 29);
            this.button2.TabIndex = 17;
            this.toolTip1.SetToolTip(this.button2, "Exit");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryOnl.database.Signup_logotype_V1;
            this.pictureBox2.Location = new System.Drawing.Point(387, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // txtEmailSignUp
            // 
            this.txtEmailSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailSignUp.Location = new System.Drawing.Point(500, 317);
            this.txtEmailSignUp.Name = "txtEmailSignUp";
            this.txtEmailSignUp.Size = new System.Drawing.Size(170, 26);
            this.txtEmailSignUp.TabIndex = 9;
            // 
            // lbFilename
            // 
            this.lbFilename.AutoSize = true;
            this.lbFilename.Location = new System.Drawing.Point(581, 483);
            this.lbFilename.Name = "lbFilename";
            this.lbFilename.Size = new System.Drawing.Size(0, 13);
            this.lbFilename.TabIndex = 15;
            // 
            // btnTabLogin
            // 
            this.btnTabLogin.BackColor = System.Drawing.Color.Aqua;
            this.btnTabLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabLogin.Location = new System.Drawing.Point(467, 520);
            this.btnTabLogin.Name = "btnTabLogin";
            this.btnTabLogin.Size = new System.Drawing.Size(86, 46);
            this.btnTabLogin.TabIndex = 0;
            this.btnTabLogin.Text = "Login";
            this.btnTabLogin.UseVisualStyleBackColor = false;
            this.btnTabLogin.Click += new System.EventHandler(this.btnTabLogin_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Khaki;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(500, 473);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSubmitSignUp
            // 
            this.btnSubmitSignUp.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSubmitSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitSignUp.Location = new System.Drawing.Point(597, 520);
            this.btnSubmitSignUp.Name = "btnSubmitSignUp";
            this.btnSubmitSignUp.Size = new System.Drawing.Size(86, 46);
            this.btnSubmitSignUp.TabIndex = 1;
            this.btnSubmitSignUp.Text = "Sign Up";
            this.btnSubmitSignUp.UseVisualStyleBackColor = false;
            this.btnSubmitSignUp.Click += new System.EventHandler(this.btnSubmitSignUp_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvatar.Image = global::LibraryOnl.database.default_img;
            this.picAvatar.InitialImage = global::LibraryOnl.database.default_img;
            this.picAvatar.Location = new System.Drawing.Point(500, 367);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(118, 100);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 13;
            this.picAvatar.TabStop = false;
            // 
            // chkPassword2
            // 
            this.chkPassword2.AutoSize = true;
            this.chkPassword2.Checked = true;
            this.chkPassword2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPassword2.Location = new System.Drawing.Point(676, 230);
            this.chkPassword2.Name = "chkPassword2";
            this.chkPassword2.Size = new System.Drawing.Size(101, 17);
            this.chkPassword2.TabIndex = 2;
            this.chkPassword2.Text = "Show password";
            this.chkPassword2.UseVisualStyleBackColor = true;
            this.chkPassword2.CheckedChanged += new System.EventHandler(this.chkPassword2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Avatar";
            // 
            // txtUsernameSginUp
            // 
            this.txtUsernameSginUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSginUp.Location = new System.Drawing.Point(500, 177);
            this.txtUsernameSginUp.Name = "txtUsernameSginUp";
            this.txtUsernameSginUp.Size = new System.Drawing.Size(170, 26);
            this.txtUsernameSginUp.TabIndex = 3;
            this.txtUsernameSginUp.TextChanged += new System.EventHandler(this.txtUsernameSginUp_TextChanged);
            // 
            // txtPasswordSginUp
            // 
            this.txtPasswordSginUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSginUp.Location = new System.Drawing.Point(500, 223);
            this.txtPasswordSginUp.Name = "txtPasswordSginUp";
            this.txtPasswordSginUp.Size = new System.Drawing.Size(170, 26);
            this.txtPasswordSginUp.TabIndex = 4;
            this.txtPasswordSginUp.TextChanged += new System.EventHandler(this.txtPasswordSginUp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fullname";
            // 
            // txtFullnameSignUp
            // 
            this.txtFullnameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullnameSignUp.Location = new System.Drawing.Point(500, 266);
            this.txtFullnameSignUp.Name = "txtFullnameSignUp";
            this.txtFullnameSignUp.Size = new System.Drawing.Size(170, 26);
            this.txtFullnameSignUp.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 486);
            this.panel2.TabIndex = 17;
            // 
            // LoginAndSignUpGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1118, 650);
            this.Controls.Add(this.tabControlLoginAndSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAndSignUpGUI";
            this.Text = "LoginAndSignUpGUI";
            this.Load += new System.EventHandler(this.LoginAndSignUpGUI_Load);
            this.tabControlLoginAndSignUp.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.tabSignup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLoginAndSignUp;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabSignup;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Button btnTabSignUp;
        private System.Windows.Forms.Button btnSubmitLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordSginUp;
        private System.Windows.Forms.TextBox txtUsernameSginUp;
        private System.Windows.Forms.CheckBox chkPassword2;
        private System.Windows.Forms.Button btnSubmitSignUp;
        private System.Windows.Forms.Button btnTabLogin;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullnameSignUp;
        private System.Windows.Forms.Label lbFilename;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}