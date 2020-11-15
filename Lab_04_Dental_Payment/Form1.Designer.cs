namespace Lab_04_Dental_Payment
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnEditPrice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbbCaoVoi = new System.Windows.Forms.CheckBox();
            this.cbbTayTrang = new System.Windows.Forms.CheckBox();
            this.cbbChupHinh = new System.Windows.Forms.CheckBox();
            this.numericTramTrang = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbCaoVoi = new System.Windows.Forms.Label();
            this.lbTayTrang = new System.Windows.Forms.Label();
            this.lbChupHinh = new System.Windows.Forms.Label();
            this.lbTramRang = new System.Windows.Forms.Label();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericTramTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trám răng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 341);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total";
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Location = new System.Drawing.Point(365, 391);
            this.btnCal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(107, 41);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "Tính tiền";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnEditPrice
            // 
            this.btnEditPrice.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEditPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPrice.Location = new System.Drawing.Point(509, 391);
            this.btnEditPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditPrice.Name = "btnEditPrice";
            this.btnEditPrice.Size = new System.Drawing.Size(148, 41);
            this.btnEditPrice.TabIndex = 12;
            this.btnEditPrice.Text = "Chỉnh sửa giá tiền";
            this.btnEditPrice.UseVisualStyleBackColor = false;
            this.btnEditPrice.Click += new System.EventHandler(this.btnEditPrice_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(692, 391);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 41);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(464, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 22);
            this.txtName.TabIndex = 14;
            // 
            // cbbCaoVoi
            // 
            this.cbbCaoVoi.AutoSize = true;
            this.cbbCaoVoi.Location = new System.Drawing.Point(306, 95);
            this.cbbCaoVoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbCaoVoi.Name = "cbbCaoVoi";
            this.cbbCaoVoi.Size = new System.Drawing.Size(80, 20);
            this.cbbCaoVoi.TabIndex = 15;
            this.cbbCaoVoi.Text = "Cạo vôi";
            this.cbbCaoVoi.UseVisualStyleBackColor = true;
            // 
            // cbbTayTrang
            // 
            this.cbbTayTrang.AutoSize = true;
            this.cbbTayTrang.Location = new System.Drawing.Point(306, 150);
            this.cbbTayTrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTayTrang.Name = "cbbTayTrang";
            this.cbbTayTrang.Size = new System.Drawing.Size(93, 20);
            this.cbbTayTrang.TabIndex = 16;
            this.cbbTayTrang.Text = "Tẩy trắng";
            this.cbbTayTrang.UseVisualStyleBackColor = true;
            // 
            // cbbChupHinh
            // 
            this.cbbChupHinh.AutoSize = true;
            this.cbbChupHinh.Location = new System.Drawing.Point(306, 213);
            this.cbbChupHinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbChupHinh.Name = "cbbChupHinh";
            this.cbbChupHinh.Size = new System.Drawing.Size(129, 20);
            this.cbbChupHinh.TabIndex = 17;
            this.cbbChupHinh.Text = "Chụp hình răng";
            this.cbbChupHinh.UseVisualStyleBackColor = true;
            // 
            // numericTramTrang
            // 
            this.numericTramTrang.Location = new System.Drawing.Point(464, 272);
            this.numericTramTrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericTramTrang.Name = "numericTramTrang";
            this.numericTramTrang.Size = new System.Drawing.Size(180, 22);
            this.numericTramTrang.TabIndex = 18;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(487, 338);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(148, 22);
            this.txtTotal.TabIndex = 19;
            // 
            // lbCaoVoi
            // 
            this.lbCaoVoi.AutoSize = true;
            this.lbCaoVoi.Location = new System.Drawing.Point(473, 96);
            this.lbCaoVoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCaoVoi.Name = "lbCaoVoi";
            this.lbCaoVoi.Size = new System.Drawing.Size(51, 16);
            this.lbCaoVoi.TabIndex = 20;
            this.lbCaoVoi.Text = "label2";
            // 
            // lbTayTrang
            // 
            this.lbTayTrang.AutoSize = true;
            this.lbTayTrang.Location = new System.Drawing.Point(473, 151);
            this.lbTayTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTayTrang.Name = "lbTayTrang";
            this.lbTayTrang.Size = new System.Drawing.Size(51, 16);
            this.lbTayTrang.TabIndex = 21;
            this.lbTayTrang.Text = "label3";
            // 
            // lbChupHinh
            // 
            this.lbChupHinh.AutoSize = true;
            this.lbChupHinh.Location = new System.Drawing.Point(473, 214);
            this.lbChupHinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChupHinh.Name = "lbChupHinh";
            this.lbChupHinh.Size = new System.Drawing.Size(51, 16);
            this.lbChupHinh.TabIndex = 22;
            this.lbChupHinh.Text = "label4";
            // 
            // lbTramRang
            // 
            this.lbTramRang.AutoSize = true;
            this.lbTramRang.Location = new System.Drawing.Point(668, 274);
            this.lbTramRang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTramRang.Name = "lbTramRang";
            this.lbTramRang.Size = new System.Drawing.Size(59, 16);
            this.lbTramRang.TabIndex = 23;
            this.lbTramRang.Text = "label11";
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLoadXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadXML.Location = new System.Drawing.Point(214, 391);
            this.btnLoadXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(107, 41);
            this.btnLoadXML.TabIndex = 24;
            this.btnLoadXML.Text = "Load xml file";
            this.btnLoadXML.UseVisualStyleBackColor = false;
            this.btnLoadXML.Click += new System.EventHandler(this.btnLoadXML_Click);
            // 
            // total
            // 
            this.total.FillWeight = 200F;
            this.total.HeaderText = "total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.total});
            this.dataGridView.Location = new System.Drawing.Point(214, 469);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(585, 231);
            this.dataGridView.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(958, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnLoadXML);
            this.Controls.Add(this.lbTramRang);
            this.Controls.Add(this.lbChupHinh);
            this.Controls.Add(this.lbTayTrang);
            this.Controls.Add(this.lbCaoVoi);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.numericTramTrang);
            this.Controls.Add(this.cbbChupHinh);
            this.Controls.Add(this.cbbTayTrang);
            this.Controls.Add(this.cbbCaoVoi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditPrice);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericTramTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnEditPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox cbbCaoVoi;
        private System.Windows.Forms.CheckBox cbbTayTrang;
        private System.Windows.Forms.CheckBox cbbChupHinh;
        private System.Windows.Forms.NumericUpDown numericTramTrang;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbCaoVoi;
        private System.Windows.Forms.Label lbTayTrang;
        private System.Windows.Forms.Label lbChupHinh;
        private System.Windows.Forms.Label lbTramRang;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
    }
}

