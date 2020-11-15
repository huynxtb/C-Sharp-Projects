using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_04
{
    public partial class frmChoice : Form
    {
        public frmChoice()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmChoice_Load(object sender, EventArgs e)
        {

        }

        private void btnLab3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab3 frm = new Lab3();
            frm.Show();
        }

        private void btnLab4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab4 frm = new Lab4();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
