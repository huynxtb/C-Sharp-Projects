using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class SearchEntity : Form
    {
        private NorthwindEntities db = new NorthwindEntities();
        public SearchEntity()
        {
            InitializeComponent();
        }
        private void ShowAll()
        {
            var list = from s in db.Suppliers select s;
            dgvTest.DataSource = list.ToList();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {

            ShowAll();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTest.DataSource = null;
            var list = from s in db.Suppliers select s;
            list = list.Where(s => s.CompanyName.Contains(txtSearch.Text));
            dgvTest.DataSource = list.ToList();
        }
    }
}
