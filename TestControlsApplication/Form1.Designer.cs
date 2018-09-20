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
            this.numberBox2 = new WinFormsControlLab.NumberBox(this.components);
            this.userControl12 = new WindowsFormsControlColor.UserControl1();
            this.SuspendLayout();
            // 
            // numberBox2
            // 
            this.numberBox2.ForeColor = System.Drawing.Color.Red;
            this.numberBox2.Location = new System.Drawing.Point(24, 12);
            this.numberBox2.Name = "numberBox2";
            this.numberBox2.Size = new System.Drawing.Size(100, 20);
            this.numberBox2.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userControl12.Location = new System.Drawing.Point(24, 52);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(346, 136);
            this.userControl12.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 502);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.numberBox2);
            this.Name = "Form1";
            this.Text = "Лабораторная 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private WinFormsControlLab.NumberBox numberBox2;
        private WindowsFormsControlColor.UserControl1 userControl11;
        private WindowsFormsControlColor.UserControl1 userControl12;
    }
}

