namespace Lab_03_04
{
    partial class frmChoice
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLab3 = new System.Windows.Forms.Button();
            this.btnLab4 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLab3);
            this.flowLayoutPanel1.Controls.Add(this.btnLab4);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(111, 154);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(570, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnLab3
            // 
            this.btnLab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLab3.Location = new System.Drawing.Point(3, 3);
            this.btnLab3.Name = "btnLab3";
            this.btnLab3.Size = new System.Drawing.Size(182, 97);
            this.btnLab3.TabIndex = 0;
            this.btnLab3.Text = "LAB 03";
            this.btnLab3.UseVisualStyleBackColor = true;
            this.btnLab3.Click += new System.EventHandler(this.btnLab3_Click);
            // 
            // btnLab4
            // 
            this.btnLab4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLab4.Location = new System.Drawing.Point(191, 3);
            this.btnLab4.Name = "btnLab4";
            this.btnLab4.Size = new System.Drawing.Size(182, 97);
            this.btnLab4.TabIndex = 1;
            this.btnLab4.Text = "LAB 04";
            this.btnLab4.UseVisualStyleBackColor = true;
            this.btnLab4.Click += new System.EventHandler(this.btnLab4_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(379, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 97);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmChoice";
            this.Text = "frmChoice";
            this.Load += new System.EventHandler(this.frmChoice_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnLab3;
        private System.Windows.Forms.Button btnLab4;
        private System.Windows.Forms.Button btnExit;
    }
}