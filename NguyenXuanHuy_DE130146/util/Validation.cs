using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenXuanHuy_DE130146.util
{
    class Validation
    {
        public static bool CheckEmptyTextbox(TextBox text, string message)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text.Focus();
                return true;
            }
            return false;
        }
    }
}
