using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_DanhMucNhanVien.Utils
{
    class CleatTxt
    {
        public static void Clear(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                Clear(c);
            }
        }
    }
}
