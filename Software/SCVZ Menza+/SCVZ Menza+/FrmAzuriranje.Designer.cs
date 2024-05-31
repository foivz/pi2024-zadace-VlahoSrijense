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
            this.cboObrok = new System.Windows.Forms.ComboBox();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVrijemeNarudzbe = new System.Windows.Forms.TextBox();
            this.txtStatusNarudzbe = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
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
            // cboObrok
            // 
            this.cboObrok.FormattingEnabled = true;
            this.cboObrok.Location = new System.Drawing.Point(380, 87);
            this.cboObrok.Name = "cboObrok";
            this.cboObrok.Size = new System.Drawing.Size(169, 24);
            this.cboObrok.TabIndex = 62;
            this.cboObrok.SelectedIndexChanged += new System.EventHandler(this.cboObrok_SelectedIndexChanged);
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(379, 182);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(171, 22);
            this.txtUkupnaCijena.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ukupna cijena:";
            // 
            // txtVrijemeNarudzbe
            // 
            this.txtVrijemeNarudzbe.Location = new System.Drawing.Point(379, 270);
            this.txtVrijemeNarudzbe.Name = "txtVrijemeNarudzbe";
            this.txtVrijemeNarudzbe.Size = new System.Drawing.Size(171, 22);
            this.txtVrijemeNarudzbe.TabIndex = 59;
            // 
            // txtStatusNarudzbe
            // 
            this.txtStatusNarudzbe.Location = new System.Drawing.Point(379, 223);
            this.txtStatusNarudzbe.Name = "txtStatusNarudzbe";
            this.txtStatusNarudzbe.Size = new System.Drawing.Size(171, 22);
            this.txtStatusNarudzbe.TabIndex = 58;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(379, 134);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(171, 22);
            this.txtKolicina.TabIndex = 57;
            this.txtKolicina.TextChanged += new System.EventHandler(this.txtKolicina_TextChanged_1);
            // 
            // txtBrojNarudžbe
            // 
            this.txtBrojNarudžbe.Location = new System.Drawing.Point(379, 43);
            this.txtBrojNarudžbe.Name = "txtBrojNarudžbe";
            this.txtBrojNarudžbe.Size = new System.Drawing.Size(171, 22);
            this.txtBrojNarudžbe.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Vrijeme narudžbe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Status narudžbe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Količina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Obrok:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Broj narudžbe:";
            // 
            // FrmAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboObrok);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVrijemeNarudzbe);
            this.Controls.Add(this.txtStatusNarudzbe);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtBrojNarudžbe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzuriraj);
            this.Name = "FrmAzuriranje";
            this.Text = "FrmAzuriranje";
            this.Load += new System.EventHandler(this.FrmAzuriranje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.ComboBox cboObrok;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVrijemeNarudzbe;
        private System.Windows.Forms.TextBox txtStatusNarudzbe;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtBrojNarudžbe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}