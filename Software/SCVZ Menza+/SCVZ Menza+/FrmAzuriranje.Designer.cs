namespace SCVZ_Menza_
{
    partial class FrmAzuriranje
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txtVrijemeNarudzbe = new System.Windows.Forms.TextBox();
            this.txtStatusNarudzbe = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtObrok = new System.Windows.Forms.TextBox();
            this.txtBrojNarudžbe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(432, 335);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(130, 54);
            this.btnOdustani.TabIndex = 47;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(263, 334);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(129, 56);
            this.btnAzuriraj.TabIndex = 46;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // txtVrijemeNarudzbe
            // 
            this.txtVrijemeNarudzbe.Location = new System.Drawing.Point(354, 244);
            this.txtVrijemeNarudzbe.Name = "txtVrijemeNarudzbe";
            this.txtVrijemeNarudzbe.Size = new System.Drawing.Size(173, 22);
            this.txtVrijemeNarudzbe.TabIndex = 45;
            this.txtVrijemeNarudzbe.TextChanged += new System.EventHandler(this.txtVrijemeNarudzbe_TextChanged);
            // 
            // txtStatusNarudzbe
            // 
            this.txtStatusNarudzbe.Location = new System.Drawing.Point(353, 197);
            this.txtStatusNarudzbe.Name = "txtStatusNarudzbe";
            this.txtStatusNarudzbe.Size = new System.Drawing.Size(174, 22);
            this.txtStatusNarudzbe.TabIndex = 44;
            this.txtStatusNarudzbe.TextChanged += new System.EventHandler(this.txtStatusNarudzbe_TextChanged);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(353, 151);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(174, 22);
            this.txtKolicina.TabIndex = 43;
            this.txtKolicina.TextChanged += new System.EventHandler(this.txtKolicina_TextChanged);
            // 
            // txtObrok
            // 
            this.txtObrok.Location = new System.Drawing.Point(353, 105);
            this.txtObrok.Name = "txtObrok";
            this.txtObrok.Size = new System.Drawing.Size(174, 22);
            this.txtObrok.TabIndex = 42;
            this.txtObrok.TextChanged += new System.EventHandler(this.txtObrok_TextChanged);
            // 
            // txtBrojNarudžbe
            // 
            this.txtBrojNarudžbe.Location = new System.Drawing.Point(353, 60);
            this.txtBrojNarudžbe.Name = "txtBrojNarudžbe";
            this.txtBrojNarudžbe.Size = new System.Drawing.Size(174, 22);
            this.txtBrojNarudžbe.TabIndex = 41;
            this.txtBrojNarudžbe.TextChanged += new System.EventHandler(this.txtBrojNarudžbe_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Vrijeme narudžbe:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Status narudžbe:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Količina:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Obrok:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Broj narudžbe:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.txtVrijemeNarudzbe);
            this.Controls.Add(this.txtStatusNarudzbe);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtObrok);
            this.Controls.Add(this.txtBrojNarudžbe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAzuriranje";
            this.Text = "FrmAzuriranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtVrijemeNarudzbe;
        private System.Windows.Forms.TextBox txtStatusNarudzbe;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtObrok;
        private System.Windows.Forms.TextBox txtBrojNarudžbe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}