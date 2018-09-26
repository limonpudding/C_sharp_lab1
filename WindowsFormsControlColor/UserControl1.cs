using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlColor
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public Color Color
        {
            get
            {
                if (radioButton1.Checked)
                    return Color.FromArgb(
                        Convert.ToInt32(numberText1.Text),
                        Convert.ToInt32(numberText2.Text),
                        Convert.ToInt32(numberText3.Text));
                else
                    return Color.FromArgb(
                    Convert.ToInt32(numberText1.Text, 16),
                    Convert.ToInt32(numberText2.Text, 16),
                    Convert.ToInt32(numberText3.Text, 16)
                    );
            }
            set
            {
                numberText1.Text = value.R.ToString();
                numberText2.Text = value.G.ToString();
                numberText3.Text = value.B.ToString();
                button1.BackColor = value;
            }
        }

        private void numberText1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                button1.BackColor = Color;
            }
            catch { }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                numberText1.Mode = "dec";
                numberText2.Mode = "dec";
                numberText3.Mode = "dec";
                numberText1.Text = Convert.ToInt32(numberText1.Text, 16).ToString();
                numberText2.Text = Convert.ToInt32(numberText2.Text, 16).ToString();
                numberText3.Text = Convert.ToInt32(numberText3.Text, 16).ToString();
            }
            else
            if (radioButton2.Checked)
            {
                numberText1.Mode = "hex";
                numberText2.Mode = "hex";
                numberText3.Mode = "hex";
                numberText1.Text = Convert.ToInt32(numberText1.Text).ToString("X");
                numberText2.Text = Convert.ToInt32(numberText2.Text).ToString("X");
                numberText3.Text = Convert.ToInt32(numberText3.Text).ToString("X");
            }
        }
    }
}
