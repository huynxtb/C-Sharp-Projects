using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Lab_04_Dental_Payment
{
    public partial class Form1 : Form
    {
        public static double caoVoi = 100000;
        public static double tayTrang = 1200000;
        public static double chupHinhRang = 200000;
        public static double tramRang = 80000;
        private string path = @"myFile.xml";
        public Form1()
        {
            InitializeComponent();
            lbCaoVoi.Text = String.Format("{0:#,#.}", caoVoi);
            lbTayTrang.Text = String.Format("{0:#,#.}", tayTrang);
            lbChupHinh.Text = String.Format("{0:#,#.}", chupHinhRang);
            lbTramRang.Text = String.Format("{0:#,#.}", tramRang) + "/Cái";
            this.CenterToScreen();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                if (cbbCaoVoi.Checked) total += caoVoi;
                if (cbbTayTrang.Checked) total += tayTrang;
                if (cbbChupHinh.Checked) total += chupHinhRang;
                if (!cbbCaoVoi.Checked && !cbbTayTrang.Checked && !cbbChupHinh.Checked && Int32.Parse(numericTramTrang.Value.ToString()) == 0)
                {
                    MessageBox.Show("Bạn chưa chọn dịch vụ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    total += tramRang * Int32.Parse(numericTramTrang.Value.ToString());
                    txtTotal.Text = String.Format("{0:#,#.}", total);

                    XDocument xml = XDocument.Load(path);
                    XElement xElement = new XElement("customer",
                                          new XElement("name", txtName.Text),
                                          new XElement("total", txtTotal.Text)
                                          );
                    var count = xml.Descendants("customer").Count();
                    xElement.SetAttributeValue("id", $"C{count + 1}");
                    xml.Element("customers").Add(xElement);
                    xml.Save(path);

                    MessageBox.Show("Thông tin đã được lưu vào xml file", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = "";
                    txtTotal.Text = "";
                    numericTramTrang.Value = 0;
                    foreach (Control item in Controls)
                    {
                        if(item is CheckBox)
                        {
                            ((CheckBox)item).Checked = false;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditPrice_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditGUI gui = new EditGUI();
            gui.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);
            XmlElement root = xdoc.DocumentElement;
            XmlNodeList list = root.SelectNodes("customer");
            int index = 0;
            foreach (XmlNode item in list)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[index].Cells[0].Value = item.Attributes["id"].Value;
                dataGridView.Rows[index].Cells[1].Value = item.SelectSingleNode("name").InnerText;
                dataGridView.Rows[index].Cells[2].Value = item.SelectSingleNode("total").InnerText;
                index++;
                //Console.WriteLine(item.Attributes["id"].Value);
                //listBox.Items.Add("Name: " + item.SelectSingleNode("name").InnerText + "  :  " +
                //                  "Total: " + item.SelectSingleNode("total").InnerText);
                //Console.WriteLine(item.SelectSingleNode("name").InnerText + "  -  " + item.SelectSingleNode("total").InnerText);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
