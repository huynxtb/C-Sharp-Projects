namespace Lab_03_UCLN_BCNN
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberA = new System.Windows.Forms.TextBox();
            this.txtNumberB = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbtUCLN = new System.Windows.Forms.RadioButton();
            this.rbtBCNN = new System.Windows.Forms.RadioButton();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // txtNumberA
            // 
            this.txtNumberA.Location = new System.Drawing.Point(272, 103);
            this.txtNumberA.Name = "txtNumberA";
            this.txtNumberA.Size = new System.Drawing.Size(100, 20);
            this.txtNumberA.TabIndex = 4;
            this.txtNumberA.TextChanged += new System.EventHandler(this.txtNumberA_TextChanged);
            // 
            // txtNumberB
            // 
            this.txtNumberB.Location = new System.Drawing.Point(272, 179);
            this.txtNumberB.Name = "txtNumberB";
            this.txtNumberB.Size = new System.Drawing.Size(100, 20);
            this.txtNumberB.TabIndex = 5;
            this.txtNumberB.TextChanged += new System.EventHandler(this.txtNumberB_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(272, 267);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 6;
            // 
            // rbtUCLN
            // 
            this.rbtUCLN.AutoSize = true;
            this.rbtUCLN.Checked = true;
            this.rbtUCLN.Location = new System.Drawing.Point(663, 138);
            this.rbtUCLN.Name = "rbtUCLN";
            this.rbtUCLN.Size = new System.Drawing.Size(54, 17);
            this.rbtUCLN.TabIndex = 7;
            this.rbtUCLN.TabStop = true;
            this.rbtUCLN.Text = "UCLN";
            this.rbtUCLN.UseVisualStyleBackColor = true;
            // 
            // rbtBCNN
            // 
            this.rbtBCNN.AutoSize = true;
            this.rbtBCNN.Location = new System.Drawing.Point(663, 195);
            this.rbtBCNN.Name = "rbtBCNN";
            this.rbtBCNN.Size = new System.Drawing.Size(55, 17);
            this.rbtBCNN.TabIndex = 8;
            this.rbtBCNN.Text = "BCNN";
            this.rbtBCNN.UseVisualStyleBackColor = true;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(195, 345);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(86, 44);
            this.btnCal.TabIndex = 9;
            this.btnCal.Text = "Tìm";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(382, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 44);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Bỏ qua";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(559, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 44);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.rbtBCNN);
            this.Controls.Add(this.rbtUCLN);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumberB);
            this.Controls.Add(this.txtNumberA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberA;
        private System.Windows.Forms.TextBox txtNumberB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbtUCLN;
        private System.Windows.Forms.RadioButton rbtBCNN;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

