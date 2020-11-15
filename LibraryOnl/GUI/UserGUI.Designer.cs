namespace LibraryOnl.GUI
{
    partial class UserGUI
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
            this.lbSession = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategorySeflHelp = new System.Windows.Forms.Button();
            this.btnCategoryComic = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnCategoryIT = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lbNotFound = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtTitleChioce = new System.Windows.Forms.TextBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSession
            // 
            this.lbSession.AutoSize = true;
            this.lbSession.BackColor = System.Drawing.Color.PeachPuff;
            this.lbSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSession.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSession.ForeColor = System.Drawing.Color.Indigo;
            this.lbSession.Location = new System.Drawing.Point(59, 128);
            this.lbSession.Name = "lbSession";
            this.lbSession.Size = new System.Drawing.Size(82, 20);
            this.lbSession.TabIndex = 0;
            this.lbSession.Text = "Welcome";
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.Image = global::LibraryOnl.database.Logout_icon_48px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(1282, 61);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 53);
            this.btnLogout.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnLogout, "Log out");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Image = global::LibraryOnl.database.exit_icon_48px;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1285, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 50);
            this.btnExit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(56, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 114);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Androgyne", 45.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(505, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 88);
            this.label7.TabIndex = 1;
            this.label7.Text = "E-Book App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.flpAdmin);
            this.panel2.Controls.Add(this.btnShowAll);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCategorySeflHelp);
            this.panel2.Controls.Add(this.btnCategoryComic);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.picAvatar);
            this.panel2.Controls.Add(this.lbSession);
            this.panel2.Controls.Add(this.btnCategoryIT);
            this.panel2.Location = new System.Drawing.Point(56, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 713);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // flpAdmin
            // 
            this.flpAdmin.Location = new System.Drawing.Point(15, 596);
            this.flpAdmin.Name = "flpAdmin";
            this.flpAdmin.Size = new System.Drawing.Size(169, 63);
            this.flpAdmin.TabIndex = 9;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.Crimson;
            this.btnShowAll.Image = global::LibraryOnl.database.Apps_Google_Chrome_App_List_icon;
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(15, 505);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(166, 58);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "         Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(20, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "-------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(45, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categories";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCategorySeflHelp
            // 
            this.btnCategorySeflHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorySeflHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorySeflHelp.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorySeflHelp.ForeColor = System.Drawing.Color.Crimson;
            this.btnCategorySeflHelp.Image = global::LibraryOnl.database.The_Help_icon;
            this.btnCategorySeflHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorySeflHelp.Location = new System.Drawing.Point(18, 417);
            this.btnCategorySeflHelp.Name = "btnCategorySeflHelp";
            this.btnCategorySeflHelp.Size = new System.Drawing.Size(166, 58);
            this.btnCategorySeflHelp.TabIndex = 5;
            this.btnCategorySeflHelp.Text = "         Self-Help";
            this.btnCategorySeflHelp.UseVisualStyleBackColor = true;
            this.btnCategorySeflHelp.Click += new System.EventHandler(this.btnCategorySeflHelp_Click);
            // 
            // btnCategoryComic
            // 
            this.btnCategoryComic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryComic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryComic.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryComic.ForeColor = System.Drawing.Color.Crimson;
            this.btnCategoryComic.Image = global::LibraryOnl.database.Comic_icon;
            this.btnCategoryComic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoryComic.Location = new System.Drawing.Point(18, 332);
            this.btnCategoryComic.Name = "btnCategoryComic";
            this.btnCategoryComic.Size = new System.Drawing.Size(166, 58);
            this.btnCategoryComic.TabIndex = 4;
            this.btnCategoryComic.Text = "         Comic";
            this.btnCategoryComic.UseVisualStyleBackColor = true;
            this.btnCategoryComic.Click += new System.EventHandler(this.btnCategoryComic_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.PeachPuff;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.Indigo;
            this.txtFullName.Location = new System.Drawing.Point(15, 151);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(169, 20);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvatar.Location = new System.Drawing.Point(39, 2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(120, 120);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // btnCategoryIT
            // 
            this.btnCategoryIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryIT.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryIT.ForeColor = System.Drawing.Color.Crimson;
            this.btnCategoryIT.Image = global::LibraryOnl.database.Programming_icon;
            this.btnCategoryIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoryIT.Location = new System.Drawing.Point(18, 247);
            this.btnCategoryIT.Name = "btnCategoryIT";
            this.btnCategoryIT.Size = new System.Drawing.Size(166, 58);
            this.btnCategoryIT.TabIndex = 3;
            this.btnCategoryIT.Text = "         IT";
            this.btnCategoryIT.UseVisualStyleBackColor = true;
            this.btnCategoryIT.Click += new System.EventHandler(this.btnCategoryIT_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelMain.Controls.Add(this.lbNotFound);
            this.panelMain.Controls.Add(this.btnSearch);
            this.panelMain.Controls.Add(this.txtSearch);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.flpMain);
            this.panelMain.Location = new System.Drawing.Point(261, 132);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1143, 719);
            this.panelMain.TabIndex = 5;
            // 
            // lbNotFound
            // 
            this.lbNotFound.AutoSize = true;
            this.lbNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotFound.ForeColor = System.Drawing.Color.Red;
            this.lbNotFound.Location = new System.Drawing.Point(211, 5);
            this.lbNotFound.Name = "lbNotFound";
            this.lbNotFound.Size = new System.Drawing.Size(0, 18);
            this.lbNotFound.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::LibraryOnl.database.search_icon_24px;
            this.btnSearch.Location = new System.Drawing.Point(440, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 32);
            this.btnSearch.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSearch, "Search with Google");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(214, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.txtTitleChioce);
            this.panel3.Controls.Add(this.btnSpeak);
            this.panel3.Controls.Add(this.picBook);
            this.panel3.Controls.Add(this.txtContent);
            this.panel3.Location = new System.Drawing.Point(672, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 624);
            this.panel3.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::LibraryOnl.database.Pause_32px;
            this.btnStop.Location = new System.Drawing.Point(319, 162);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnStop, "Stop");
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtTitleChioce
            // 
            this.txtTitleChioce.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtTitleChioce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitleChioce.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleChioce.ForeColor = System.Drawing.Color.Black;
            this.txtTitleChioce.Location = new System.Drawing.Point(57, 197);
            this.txtTitleChioce.Name = "txtTitleChioce";
            this.txtTitleChioce.ReadOnly = true;
            this.txtTitleChioce.Size = new System.Drawing.Size(352, 26);
            this.txtTitleChioce.TabIndex = 3;
            this.txtTitleChioce.Text = "You have not selected a book";
            this.txtTitleChioce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSpeak
            // 
            this.btnSpeak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeak.FlatAppearance.BorderSize = 0;
            this.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeak.Image = global::LibraryOnl.database.Play_icon_32px;
            this.btnSpeak.Location = new System.Drawing.Point(357, 162);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(32, 32);
            this.btnSpeak.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSpeak, "Play");
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // picBook
            // 
            this.picBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBook.Location = new System.Drawing.Point(154, 3);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(161, 188);
            this.picBook.TabIndex = 2;
            this.picBook.TabStop = false;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(3, 226);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(448, 398);
            this.txtContent.TabIndex = 0;
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flpMain.Location = new System.Drawing.Point(22, 59);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(644, 624);
            this.flpMain.TabIndex = 0;
            // 
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1463, 863);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserGUI";
            this.Load += new System.EventHandler(this.UserGUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserGUI_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSession;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCategoryIT;
        private System.Windows.Forms.TextBox txtTitleChioce;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCategorySeflHelp;
        private System.Windows.Forms.Button btnCategoryComic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.FlowLayoutPanel flpAdmin;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbNotFound;
    }
}