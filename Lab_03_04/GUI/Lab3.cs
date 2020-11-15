using Lab_03_04.DTO.lab3;
using Lab_03_04.Utils;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
namespace Lab_03_04
{

    public partial class Lab3 : Form
    {
        private string path = @"employees.txt";
        DataTable table;
        private string Email;
        public Lab3()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #region methods
        private bool IsEmpty()
        {
            if (Validation.IsEmptyString(txtName, "Name can't be null")) return false;
            if (Validation.IsEmptyString(txtAge, "Age can't be null")) return false;
            if (Validation.IsEmptyString(txtAddress, "Address can't be null")) return false;
            if (Validation.IsEmptyString(txtYearOfExp, "Year of exp can't be null")) return false;
            if (Validation.IsEmptyString(txtPhone, "Phone can't be null")) return false;
            if (Validation.IsEmptyString(txtEmail, "Email can't be null")) return false;
            if (!Validation.ValidEmail(txtEmail, "Incorect format email")) return false;
            return true;
        }
        private bool IsExistedEmail()
        {
            string[] lines = File.ReadAllLines(path);
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                Console.WriteLine(values[5]);
                if (values[5] == txtEmail.Text)
                {
                    return false;
                }
            }
            return true;
        }
        private void LoadTable()
        {
            table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Years of Exp", typeof(int));
            table.Columns.Add("Phone number", typeof(string));
            table.Columns.Add("Email ", typeof(string));
            table.Columns.Add("Date of Joining ", typeof(DateTime));
            dgvEmployees.DataSource = table;
            LoadFileToDGV();
            dgvEmployees.EnableHeadersVisualStyles = false;
            for (int i = 0; i < dgvEmployees.Columns.Count; i++)
            {
                dgvEmployees.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvEmployees.Columns[i].HeaderCell.Style.ForeColor = Color.Blue;
                //dgvEmployees.Columns[1].DefaultCellStyle.ForeColor = Color.Red;
            }
            dgvEmployees.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private bool RegexNumber(TextBox text, string s)
        {
            if (Regex.IsMatch(text.Text, "[^0-9]"))
            {
                MessageBox.Show(s, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text.Text = "";
                text.Focus();
                return false;
            }
            else return true;
        }
        private void LoadFileToDGV()
        {
            string[] lines = File.ReadAllLines(path);
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            } 
        }
        #endregion

        #region events click
        private void Lab3_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtPhone.Text);
            if (IsEmpty())
            {
                if (IsExistedEmail())
                {
                    Employee emp = new Employee();
                    emp.Name = txtName.Text;
                    emp.Age = Int32.Parse(txtAge.Text);
                    emp.Address = txtAddress.Text;
                    emp.YearOfExp = Int32.Parse(txtYearOfExp.Text);
                    emp.Phone = txtPhone.Text;
                    emp.Email = txtEmail.Text;
                    emp.DateOfJoin = dtpDateOfJoin.Value.Date;

                    using (StreamWriter file = new StreamWriter(path, true))
                    {
                        file.WriteLine(emp.ToString());
                        file.Close();
                    }
                    MessageBox.Show("Insert success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine(emp.ToString());
                    table = null;
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Email is already in system", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
      
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtPhone.Text);
            string[] lines = File.ReadAllLines(path);
            string[] values;
            if (IsEmpty())
            {
                Employee emp = new Employee();
                emp.Name = txtName.Text;
                emp.Age = Int32.Parse(txtAge.Text);
                emp.Address = txtAddress.Text;
                emp.YearOfExp = Int32.Parse(txtYearOfExp.Text);
                emp.Phone = txtPhone.Text;
                emp.Email = txtEmail.Text;
                emp.DateOfJoin = dtpDateOfJoin.Value.Date;

                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split(',');
                    if (values[5] == Email)
                    {
                        lines[i] = emp.ToString();
                    }
                }
                File.WriteAllLines(path, lines);
                MessageBox.Show("Update success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                table = null;
                LoadTable();
            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string[] lines = File.ReadAllLines(path);
                string[] values;
                
                for (int i = 0; i < lines.Length; i++)
                {
                    //values = lines[i].ToString().Split(',');
                    values = lines[i].ToString().Split(',');

                    Console.WriteLine(values[5]);

                    if (values[5] == Email)
                    {
                        File.WriteAllLines(path, File.ReadLines(path).Where(l => l != lines[i]).ToList());
                    }
                }
                MessageBox.Show("Delete success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                table = null;
                LoadTable();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearTextBox.Clear(this);
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to  open TalkTime with google chrome?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string search = "http://talktime.com";
                Process.Start(search);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (RegexNumber(txtAge, "Must be digit"))
            {
                if (txtAge.Text!="")
                {
                    if (int.Parse(txtAge.Text) <= 0)
                    {
                        MessageBox.Show("Age must be > 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtAge.Text = "";
                        txtAge.Focus();
                    }
                }
            }
       
        }

        private void txtYearOfExp_TextChanged(object sender, EventArgs e)
        {
            if (RegexNumber(txtYearOfExp, "Must be digit"))
            {
                if (txtYearOfExp.Text != "")
                {
                    if (int.Parse(txtYearOfExp.Text) < 0)
                    {
                        MessageBox.Show("Year of Exp must be >= 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtYearOfExp.Text = "";
                        txtYearOfExp.Focus();
                    }
                }
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (RegexNumber(txtPhone, "Must be digit")) ;
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtName.Text = dgvEmployees.Rows[index].Cells[0].Value.ToString();
                txtAge.Text = dgvEmployees.Rows[index].Cells[1].Value.ToString();
                txtAddress.Text = dgvEmployees.Rows[index].Cells[2].Value.ToString();
                txtYearOfExp.Text = dgvEmployees.Rows[index].Cells[3].Value.ToString();
                txtPhone.Text = dgvEmployees.Rows[index].Cells[4].Value.ToString();
                txtEmail.Text = dgvEmployees.Rows[index].Cells[5].Value.ToString();
                Email = dgvEmployees.Rows[index].Cells[5].Value.ToString();
                dtpDateOfJoin.Value = (DateTime)dgvEmployees.Rows[index].Cells[6].Value;

            }
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChoice frm = new frmChoice();
            frm.Show();
        }
        #endregion
    }
}
