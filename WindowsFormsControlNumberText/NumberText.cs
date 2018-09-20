using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlNumberText
{
    public partial class NumberText : TextBox
    {
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                e.Handled = true;
            base.OnKeyPress(e);
        }


        protected override void OnTextChanged(EventArgs e)
        {
            try
            {
                if (Text == "")
                    Text = "0";
                if (Convert.ToInt32(Text) > 255)
                    Text = "255";
            }
            catch { }
            base.OnTextChanged(e);
        }
    }
}
