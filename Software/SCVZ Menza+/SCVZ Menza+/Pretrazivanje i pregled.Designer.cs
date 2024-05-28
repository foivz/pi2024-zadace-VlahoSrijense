namespace SCVZ_Menza_
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
            this.gumbPretrazi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Brisanje = new System.Windows.Forms.Button();
            this.gumbAzuriranje = new System.Windows.Forms.Button();
            this.gumbNarudzba = new System.Windows.Forms.Button();
            this.pregledNarudzbi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pregledNarudzbi)).BeginInit();
            this.SuspendLayout();
            // 
            // gumbPretrazi
            // 
            this.gumbPretrazi.Location = new System.Drawing.Point(610, 35);
            this.gumbPretrazi.Name = "gumbPretrazi";
            this.gumbPretrazi.Size = new System.Drawing.Size(98, 21);
            this.gumbPretrazi.TabIndex = 13;
            this.gumbPretrazi.Text = "Pretraži";
            this.gumbPretrazi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pregled Narudžbi:";
            // 
            // Brisanje
            // 
            this.Brisanje.Location = new System.Drawing.Point(401, 372);
            this.Brisanje.Name = "Brisanje";
            this.Brisanje.Size = new System.Drawing.Size(121, 56);
            this.Brisanje.TabIndex = 10;
            this.Brisanje.Text = "Brisanje";
            this.Brisanje.UseVisualStyleBackColor = true;
            // 
            // gumbAzuriranje
            // 
            this.gumbAzuriranje.Location = new System.Drawing.Point(252, 372);
            this.gumbAzuriranje.Name = "gumbAzuriranje";
            this.gumbAzuriranje.Size = new System.Drawing.Size(121, 56);
            this.gumbAzuriranje.TabIndex = 9;
            this.gumbAzuriranje.Text = "Ažuriranje";
            this.gumbAzuriranje.UseVisualStyleBackColor = true;
            // 
            // gumbNarudzba
            // 
            this.gumbNarudzba.Location = new System.Drawing.Point(104, 372);
            this.gumbNarudzba.Name = "gumbNarudzba";
            this.gumbNarudzba.Size = new System.Drawing.Size(121, 56);
            this.gumbNarudzba.TabIndex = 8;
            this.gumbNarudzba.Text = "Naručivanje";
            this.gumbNarudzba.UseVisualStyleBackColor = true;
            // 
            // pregledNarudzbi
            // 
            this.pregledNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pregledNarudzbi.Location = new System.Drawing.Point(104, 112);
            this.pregledNarudzbi.Name = "pregledNarudzbi";
            this.pregledNarudzbi.RowHeadersWidth = 51;
            this.pregledNarudzbi.RowTemplate.Height = 24;
            this.pregledNarudzbi.Size = new System.Drawing.Size(605, 239);
            this.pregledNarudzbi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 463);
            this.Controls.Add(this.gumbPretrazi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Brisanje);
            this.Controls.Add(this.gumbAzuriranje);
            this.Controls.Add(this.gumbNarudzba);
            this.Controls.Add(this.pregledNarudzbi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pregledNarudzbi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbPretrazi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Brisanje;
        private System.Windows.Forms.Button gumbAzuriranje;
        private System.Windows.Forms.Button gumbNarudzba;
        private System.Windows.Forms.DataGridView pregledNarudzbi;
    }
}

