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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAzuriranje));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdustani.Location = new System.Drawing.Point(578, 393);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(162, 61);
            this.btnOdustani.TabIndex = 47;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAzuriraj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAzuriraj.Location = new System.Drawing.Point(384, 392);
            this.btnAzuriraj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(161, 63);
            this.btnAzuriraj.TabIndex = 46;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // cboObrok
            // 
            this.cboObrok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObrok.FormattingEnabled = true;
            this.cboObrok.Location = new System.Drawing.Point(529, 114);
            this.cboObrok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboObrok.Name = "cboObrok";
            this.cboObrok.Size = new System.Drawing.Size(210, 26);
            this.cboObrok.TabIndex = 62;
            this.cboObrok.SelectedIndexChanged += new System.EventHandler(this.cboObrok_SelectedIndexChanged);
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(527, 221);
            this.txtUkupnaCijena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.ReadOnly = true;
            this.txtUkupnaCijena.Size = new System.Drawing.Size(213, 24);
            this.txtUkupnaCijena.TabIndex = 61;
            this.txtUkupnaCijena.TextChanged += new System.EventHandler(this.txtUkupnaCijena_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(397, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Ukupna cijena:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtVrijemeNarudzbe
            // 
            this.txtVrijemeNarudzbe.Location = new System.Drawing.Point(527, 320);
            this.txtVrijemeNarudzbe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVrijemeNarudzbe.Name = "txtVrijemeNarudzbe";
            this.txtVrijemeNarudzbe.ReadOnly = true;
            this.txtVrijemeNarudzbe.Size = new System.Drawing.Size(213, 24);
            this.txtVrijemeNarudzbe.TabIndex = 59;
            this.txtVrijemeNarudzbe.TextChanged += new System.EventHandler(this.txtVrijemeNarudzbe_TextChanged);
            // 
            // txtStatusNarudzbe
            // 
            this.txtStatusNarudzbe.Location = new System.Drawing.Point(527, 267);
            this.txtStatusNarudzbe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStatusNarudzbe.Name = "txtStatusNarudzbe";
            this.txtStatusNarudzbe.ReadOnly = true;
            this.txtStatusNarudzbe.Size = new System.Drawing.Size(213, 24);
            this.txtStatusNarudzbe.TabIndex = 58;
            this.txtStatusNarudzbe.TextChanged += new System.EventHandler(this.txtStatusNarudzbe_TextChanged);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(527, 167);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(213, 24);
            this.txtKolicina.TabIndex = 57;
            this.txtKolicina.TextChanged += new System.EventHandler(this.txtKolicina_TextChanged_1);
            // 
            // txtBrojNarudžbe
            // 
            this.txtBrojNarudžbe.Location = new System.Drawing.Point(527, 64);
            this.txtBrojNarudžbe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBrojNarudžbe.Name = "txtBrojNarudžbe";
            this.txtBrojNarudžbe.ReadOnly = true;
            this.txtBrojNarudžbe.Size = new System.Drawing.Size(213, 24);
            this.txtBrojNarudžbe.TabIndex = 56;
            this.txtBrojNarudžbe.TextChanged += new System.EventHandler(this.txtBrojNarudžbe_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(381, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "Vrijeme narudžbe:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(389, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Status narudžbe:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(450, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Količina:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(463, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Obrok:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(405, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Broj narudžbe:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCVZ_Menza_.Properties.Resources.Dizajn_bez_naslova_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(75, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(842, 506);
            this.Controls.Add(this.pictureBox1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmAzuriranje";
            this.Text = "FrmAzuriranje";
            this.Load += new System.EventHandler(this.FrmAzuriranje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}