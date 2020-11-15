﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_04.Utils
{
    class ClearTextBox
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
