using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlNumberText
{
    public partial class NumberText : TextBox
    {
        public string Mode = "dec";//hex/dec

        public NumberText()
        {
            InitializeComponent();
        }

        public NumberText(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (Mode == "hex")
            {
                if (!Regex.IsMatch(e.KeyChar.ToString(), @"[0-9,a-f,A-F]+") && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Mode == "dec")
                try
                {
                    if (Text == "")
                        Text = "0";
                    if (Convert.ToInt32(Text) > 255)
                        Text = "255";
                }
                catch { }
            else
                try
                {
                    if (Text == "")
                        Text = "0";
                    if (Convert.ToInt32(Text, 16) > 255)
                        Text = "FF";
                }
                catch { }
            base.OnTextChanged(e);
        }
    }
}
