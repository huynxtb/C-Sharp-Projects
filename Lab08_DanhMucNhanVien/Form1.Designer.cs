namespace Lab08_DanhMucNhanVien
{
    partial class FormNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbBangCapNV = new System.Windows.Forms.ComboBox();
            this.bANGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab08chsarpDataSet1 = new Lab08_DanhMucNhanVien.lab08chsarpDataSet1();
            this.txtAddressNV = new System.Windows.Forms.TextBox();
            this.txtPhoneNV = new System.Windows.Forms.TextBox();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.dtpDateNV = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnDelNV = new System.Windows.Forms.Button();
            this.btnCancelNV = new System.Windows.Forms.Button();
            this.btnExitNV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBangCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab08chsarpDataSet = new Lab08_DanhMucNhanVien.lab08chsarpDataSet();
            this.nHANVIENTableAdapter = new Lab08_DanhMucNhanVien.lab08chsarpDataSetTableAdapters.NHANVIENTableAdapter();
            this.bANGCAPTableAdapter = new Lab08_DanhMucNhanVien.lab08chsarpDataSet1TableAdapters.BANGCAPTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab08chsarpDataSet1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab08chsarpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbBangCapNV);
            this.groupBox1.Controls.Add(this.txtAddressNV);
            this.groupBox1.Controls.Add(this.txtPhoneNV);
            this.groupBox1.Controls.Add(this.txtNameNV);
            this.groupBox1.Controls.Add(this.dtpDateNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(204, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(907, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bằng cấp";
            // 
            // cbbBangCapNV
            // 
            this.cbbBangCapNV.DataSource = this.bANGCAPBindingSource;
            this.cbbBangCapNV.DisplayMember = "TenBangCap";
            this.cbbBangCapNV.FormattingEnabled = true;
            this.cbbBangCapNV.Location = new System.Drawing.Point(585, 93);
            this.cbbBangCapNV.Name = "cbbBangCapNV";
            this.cbbBangCapNV.Size = new System.Drawing.Size(192, 24);
            this.cbbBangCapNV.TabIndex = 8;
            this.cbbBangCapNV.ValueMember = "MaBangCap";
            // 
            // bANGCAPBindingSource
            // 
            this.bANGCAPBindingSource.DataMember = "BANGCAP";
            this.bANGCAPBindingSource.DataSource = this.lab08chsarpDataSet1;
            // 
            // lab08chsarpDataSet1
            // 
            this.lab08chsarpDataSet1.DataSetName = "lab08chsarpDataSet1";
            this.lab08chsarpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAddressNV
            // 
            this.txtAddressNV.Location = new System.Drawing.Point(123, 149);
            this.txtAddressNV.Name = "txtAddressNV";
            this.txtAddressNV.Size = new System.Drawing.Size(298, 22);
            this.txtAddressNV.TabIndex = 7;
            // 
            // txtPhoneNV
            // 
            this.txtPhoneNV.Location = new System.Drawing.Point(585, 32);
            this.txtPhoneNV.Name = "txtPhoneNV";
            this.txtPhoneNV.Size = new System.Drawing.Size(298, 22);
            this.txtPhoneNV.TabIndex = 6;
            // 
            // txtNameNV
            // 
            this.txtNameNV.Location = new System.Drawing.Point(123, 32);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(298, 22);
            this.txtNameNV.TabIndex = 5;
            // 
            // dtpDateNV
            // 
            this.dtpDateNV.Location = new System.Drawing.Point(123, 91);
            this.dtpDateNV.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateNV.Name = "dtpDateNV";
            this.dtpDateNV.Size = new System.Drawing.Size(298, 22);
            this.dtpDateNV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Danh Mục Nhân Viên";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddNV);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdateNV);
            this.flowLayoutPanel1.Controls.Add(this.btnDelNV);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelNV);
            this.flowLayoutPanel1.Controls.Add(this.btnExitNV);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(475, 323);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(408, 48);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.Lime;
            this.btnAddNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNV.Location = new System.Drawing.Point(3, 3);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(75, 45);
            this.btnAddNV.TabIndex = 0;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNV.Location = new System.Drawing.Point(84, 3);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(75, 45);
            this.btnUpdateNV.TabIndex = 1;
            this.btnUpdateNV.Text = "Sửa";
            this.btnUpdateNV.UseVisualStyleBackColor = false;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDelNV
            // 
            this.btnDelNV.BackColor = System.Drawing.Color.Red;
            this.btnDelNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelNV.Location = new System.Drawing.Point(165, 3);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(75, 45);
            this.btnDelNV.TabIndex = 2;
            this.btnDelNV.Text = "Xoá";
            this.btnDelNV.UseVisualStyleBackColor = false;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnCancelNV
            // 
            this.btnCancelNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNV.Location = new System.Drawing.Point(246, 3);
            this.btnCancelNV.Name = "btnCancelNV";
            this.btnCancelNV.Size = new System.Drawing.Size(75, 45);
            this.btnCancelNV.TabIndex = 3;
            this.btnCancelNV.Text = "Huỷ";
            this.btnCancelNV.UseVisualStyleBackColor = false;
            this.btnCancelNV.Click += new System.EventHandler(this.btnCancelNV_Click);
            // 
            // btnExitNV
            // 
            this.btnExitNV.BackColor = System.Drawing.Color.Magenta;
            this.btnExitNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitNV.Location = new System.Drawing.Point(327, 3);
            this.btnExitNV.Name = "btnExitNV";
            this.btnExitNV.Size = new System.Drawing.Size(75, 45);
            this.btnExitNV.TabIndex = 4;
            this.btnExitNV.Text = "Thoát";
            this.btnExitNV.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(265, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 279);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.hoTenNhanVienDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.dienThoaiDataGridViewTextBoxColumn,
            this.maBangCapDataGridViewTextBoxColumn});
            this.dgvNhanVien.DataSource = this.nHANVIENBindingSource;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 21);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.Size = new System.Drawing.Size(788, 258);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNhanVienDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoTenNhanVienDataGridViewTextBoxColumn
            // 
            this.hoTenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "HoTenNhanVien";
            this.hoTenNhanVienDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenNhanVienDataGridViewTextBoxColumn.Name = "hoTenNhanVienDataGridViewTextBoxColumn";
            this.hoTenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dienThoaiDataGridViewTextBoxColumn
            // 
            this.dienThoaiDataGridViewTextBoxColumn.DataPropertyName = "DienThoai";
            this.dienThoaiDataGridViewTextBoxColumn.HeaderText = "Điện thoại";
            this.dienThoaiDataGridViewTextBoxColumn.Name = "dienThoaiDataGridViewTextBoxColumn";
            this.dienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maBangCapDataGridViewTextBoxColumn
            // 
            this.maBangCapDataGridViewTextBoxColumn.DataPropertyName = "MaBangCap";
            this.maBangCapDataGridViewTextBoxColumn.HeaderText = "Mã bằng cấp";
            this.maBangCapDataGridViewTextBoxColumn.Name = "maBangCapDataGridViewTextBoxColumn";
            this.maBangCapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.lab08chsarpDataSet;
            // 
            // lab08chsarpDataSet
            // 
            this.lab08chsarpDataSet.DataSetName = "lab08chsarpDataSet";
            this.lab08chsarpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bANGCAPTableAdapter
            // 
            this.bANGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1287, 691);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhanVien";
            this.Text = "Form Nhân Viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab08chsarpDataSet1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab08chsarpDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddressNV;
        private System.Windows.Forms.TextBox txtPhoneNV;
        private System.Windows.Forms.TextBox txtNameNV;
        private System.Windows.Forms.DateTimePicker dtpDateNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbBangCapNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button btnDelNV;
        private System.Windows.Forms.Button btnCancelNV;
        private System.Windows.Forms.Button btnExitNV;
        private lab08chsarpDataSet lab08chsarpDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private lab08chsarpDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private lab08chsarpDataSet1 lab08chsarpDataSet1;
        private System.Windows.Forms.BindingSource bANGCAPBindingSource;
        private lab08chsarpDataSet1TableAdapters.BANGCAPTableAdapter bANGCAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBangCapDataGridViewTextBoxColumn;
    }
}

