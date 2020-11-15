using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_DanhMucNhanVien.Utils
{
    class Validation
    {
        public static bool IsEmptyTxt(TextBox text, string message)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text.Focus();
                return true;
            }
            return false;
        }

        public static bool CheckInt(TextBox text, string message)
        {
            if (Regex.IsMatch(text.Text, "[^0-9]"))
            {
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text.Focus();
                return true;
            }
            return false;
        }
    }
}
