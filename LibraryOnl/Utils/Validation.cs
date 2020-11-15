using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOnl.Utils
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

        public static bool ValidEmail(TextBox text, string message)
        {
            try
            {
                MailAddress mail = new MailAddress(text.Text);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                text.Focus();
                return false;
            }
        }

        public static bool CheckEmptyLabel(Label label, string message)
        {
            if (label.Text == "")
            {
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

    }
}
