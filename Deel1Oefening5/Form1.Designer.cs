namespace Deel1Oefening5
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
            this.userControlSpeler1 = new Deel1Oefening5.UserControlSpeler();
            this.SuspendLayout();
            // 
            // userControlSpeler1
            // 
            this.userControlSpeler1.Location = new System.Drawing.Point(12, 3);
            this.userControlSpeler1.Name = "userControlSpeler1";
            this.userControlSpeler1.Size = new System.Drawing.Size(1367, 908);
            this.userControlSpeler1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 1028);
            this.Controls.Add(this.userControlSpeler1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlSpeler userControlSpeler1;
    }
}

