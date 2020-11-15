using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_04.Utils
{
    class Validation
    {
        public static bool IsEmptyString(TextBox text, string message)
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
    }
}
