using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOnl.Utils
{
    class ClearTextBox
    {
        public static void clearTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                clearTextBox(c);
            }
        }
    }
}
