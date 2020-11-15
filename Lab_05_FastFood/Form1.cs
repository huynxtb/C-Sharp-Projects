using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05_FastFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void add(Button btn)
        {
            //Boolean value to check if the DataGridView has the same value.  
            bool Found = false;
            if (dgvInfo.Rows.Count > 0)
            {
                //Check if the product Name exists with the same Price  
                foreach (DataGridViewRow row in dgvInfo.Rows)
                {
                    if ((string)row.Cells[0].Value == btn.Text)
                    {
                        //Update the Quantity of the found row  
                        row.Cells[1].Value =  (int)row.Cells[1].Value + 1;
                        Found = true;
                    }
                }
                if (!Found)
                {
                    //Add the row to DataGridView if data not present  
                    dgvInfo.Rows.Add(btn.Text, 1);
                }
            }
            else
            {
                //Add the first row to DataGridView if there is no row  
                dgvInfo.Rows.Add(btn.Text, 1);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int dgvCount = dgvInfo.Rows.Count;
            int selected = dgvInfo.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (dgvCount > 0)
            {
                if (selected > 0)
                {
                    foreach (DataGridViewRow item in dgvInfo.SelectedRows)
                    {
                        dgvInfo.Rows.Remove(item);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn mục", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu trong bảng", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int count = dgvInfo.Rows.Count;
            StringBuilder sb = new StringBuilder();
            if(cbbTable.SelectedItem != null)
            {
                if(count != 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        sb.Append(dgvInfo.Rows[i].Cells["name"].Value.ToString() + ": " +
                                  dgvInfo.Rows[i].Cells["quarity"].Value.ToString() + "\n");
                    }
                    MessageBox.Show("Bàn số " + cbbTable.SelectedItem.ToString() +"\n"+ sb.ToString(), "Thông tin hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add(this.btnBo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add(this.button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add(this.button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            add(this.button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add(this.button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add(this.button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            add(this.button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            add(this.button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            add(this.button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            add(this.button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            add(this.button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            add(this.button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            add(this.button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            add(this.button14);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            add(this.button16);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dgvInfo_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void dgvInfo_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }
    }
}
