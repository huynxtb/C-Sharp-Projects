using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;

namespace SimplePaging
{
    public partial class Form1 : Form
    {
        private int pageNumber = 1;
        private IPagedList<Product> list;
        public Form1()
        {
            InitializeComponent();
        }

        public async Task<IPagedList<Product>> GetPageListAsync(int pageNumber = 1, int pageSize = 10)
        {
            return await Task.Factory.StartNew(() =>
           {
               using (NorthwindEntities db = new NorthwindEntities())
               {
                   return db.Products.OrderBy(p => p.ProductID).ToPagedList(pageNumber, pageSize);
               }
           });
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            list = await GetPageListAsync();
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            dataGridView1.DataSource = list.ToList();
            label1.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await GetPageListAsync(--pageNumber);
                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dataGridView1.DataSource = list.ToList();
                label1.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await GetPageListAsync(++pageNumber);
                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dataGridView1.DataSource = list.ToList();
                label1.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
            }
        }
    }
}
