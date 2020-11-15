using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_Dental_Payment
{
    public partial class EditGUI : Form
    {
        public EditGUI()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gui = new Form1();
            gui.Show();
        }

        private void EditGUI_Load(object sender, EventArgs e)
        {
            txtCaoVoi.Text = String.Format("{0:#,#.}", Form1.caoVoi);
            txtChupHinh.Text = String.Format("{0:#,#.}", Form1.chupHinhRang); 
            txtTayTrang.Text = String.Format("{0:#,#.}", Form1.tayTrang); 
            txtTramRang.Text = String.Format("{0:#,#.}", Form1.tramRang); 
        }

        private void txtCaoVoi_TextChanged(object sender, EventArgs e)
        {
            Form1.caoVoi = Double.Parse(txtCaoVoi.Text);
        }

        private void txtTayTrang_TextChanged(object sender, EventArgs e)
        {
            Form1.tayTrang = Double.Parse(txtTayTrang.Text);
        }

        private void txtChupHinh_TextChanged(object sender, EventArgs e)
        {
            Form1.chupHinhRang = Double.Parse(txtChupHinh.Text);
        }

        private void txtTramRang_TextChanged(object sender, EventArgs e)
        {
            Form1.tramRang = Double.Parse(txtTramRang.Text);
        }
    }
}
