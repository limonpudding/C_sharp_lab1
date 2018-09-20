namespace TestControlsApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userControl11 = new WindowsFormsControlColor.UserControl1();
            this.numberText1 = new WindowsFormsControlNumberText.NumberText(this.components);
            this.numberBox1 = new WinFormsControlLab.NumberBox(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.clock1 = new WinFormsControlLab.Clock();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userControl11.Location = new System.Drawing.Point(12, 38);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(346, 136);
            this.userControl11.TabIndex = 1;
            // 
            // numberText1
            // 
            this.numberText1.Location = new System.Drawing.Point(135, 12);
            this.numberText1.Name = "numberText1";
            this.numberText1.Size = new System.Drawing.Size(100, 20);
            this.numberText1.TabIndex = 2;
            this.numberText1.Text = "0";
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(12, 12);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(100, 20);
            this.numberBox1.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 201);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(326, 301);
            this.elementHost1.TabIndex = 3;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.clock1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(360, 522);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.numberText1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.numberBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WinFormsControlLab.NumberBox numberBox1;
        private WindowsFormsControlColor.UserControl1 userControl11;
        private WindowsFormsControlNumberText.NumberText numberText1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WinFormsControlLab.Clock clock1;
    }
}

