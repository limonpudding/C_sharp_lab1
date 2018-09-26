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
    public partial class FileController : UserControl
    {
        public FileController()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = textBox1.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox1.Text = ofd.FileName;

        }
    }
}
