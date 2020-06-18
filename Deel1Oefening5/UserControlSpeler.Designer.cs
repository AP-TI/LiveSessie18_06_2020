namespace Deel1Oefening5
{
    partial class UserControlSpeler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonZoek = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxZoek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNaam = new System.Windows.Forms.TextBox();
            this.buttonVoegToe = new System.Windows.Forms.Button();
            this.textBoxSpelersnr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZoek
            // 
            this.buttonZoek.Location = new System.Drawing.Point(1098, 23);
            this.buttonZoek.Name = "buttonZoek";
            this.buttonZoek.Size = new System.Drawing.Size(227, 33);
            this.buttonZoek.TabIndex = 1;
            this.buttonZoek.Text = "Zoek";
            this.buttonZoek.UseVisualStyleBackColor = true;
            this.buttonZoek.Click += new System.EventHandler(this.buttonZoek_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 648);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBoxZoek
            // 
            this.textBoxZoek.Location = new System.Drawing.Point(227, 23);
            this.textBoxZoek.Name = "textBoxZoek";
            this.textBoxZoek.Size = new System.Drawing.Size(865, 26);
            this.textBoxZoek.TabIndex = 3;
            this.textBoxZoek.TextChanged += new System.EventHandler(this.textBoxZoek_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 742);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nieuwe toevoegen";
            // 
            // textBoxNaam
            // 
            this.textBoxNaam.Location = new System.Drawing.Point(164, 742);
            this.textBoxNaam.Name = "textBoxNaam";
            this.textBoxNaam.Size = new System.Drawing.Size(221, 26);
            this.textBoxNaam.TabIndex = 6;
            // 
            // buttonVoegToe
            // 
            this.buttonVoegToe.Location = new System.Drawing.Point(402, 731);
            this.buttonVoegToe.Name = "buttonVoegToe";
            this.buttonVoegToe.Size = new System.Drawing.Size(118, 43);
            this.buttonVoegToe.TabIndex = 7;
            this.buttonVoegToe.Text = "Voeg toe";
            this.buttonVoegToe.UseVisualStyleBackColor = true;
            this.buttonVoegToe.Click += new System.EventHandler(this.buttonVoegToe_Click);
            // 
            // textBoxSpelersnr
            // 
            this.textBoxSpelersnr.Location = new System.Drawing.Point(164, 775);
            this.textBoxSpelersnr.Name = "textBoxSpelersnr";
            this.textBoxSpelersnr.Size = new System.Drawing.Size(100, 26);
            this.textBoxSpelersnr.TabIndex = 8;
            // 
            // UserControlSpeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSpelersnr);
            this.Controls.Add(this.buttonVoegToe);
            this.Controls.Add(this.textBoxNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxZoek);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonZoek);
            this.Name = "UserControlSpeler";
            this.Size = new System.Drawing.Size(1367, 908);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonZoek;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxZoek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNaam;
        private System.Windows.Forms.Button buttonVoegToe;
        private System.Windows.Forms.TextBox textBoxSpelersnr;
    }
}
