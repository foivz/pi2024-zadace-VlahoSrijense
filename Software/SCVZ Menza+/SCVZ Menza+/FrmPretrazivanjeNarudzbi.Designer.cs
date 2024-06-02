namespace SCVZ_Menza_
{
    partial class FrmPretrazivanjeNarudzbi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretrazivanjeNarudzbi));
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnAzuriranje = new System.Windows.Forms.Button();
            this.btnNarucivanje = new System.Windows.Forms.Button();
            this.dgvPregledNarudzbi = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledNarudzbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPretrazi.Location = new System.Drawing.Point(779, 78);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(99, 39);
            this.btnPretrazi.TabIndex = 20;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(513, 86);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(248, 22);
            this.txtPretrazivanje.TabIndex = 19;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pregled Narudžbi:";
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisanje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBrisanje.Location = new System.Drawing.Point(789, 524);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(121, 56);
            this.btnBrisanje.TabIndex = 17;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // btnAzuriranje
            // 
            this.btnAzuriranje.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAzuriranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriranje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAzuriranje.Location = new System.Drawing.Point(640, 524);
            this.btnAzuriranje.Name = "btnAzuriranje";
            this.btnAzuriranje.Size = new System.Drawing.Size(121, 56);
            this.btnAzuriranje.TabIndex = 16;
            this.btnAzuriranje.Text = "Ažuriranje";
            this.btnAzuriranje.UseVisualStyleBackColor = false;
            this.btnAzuriranje.Click += new System.EventHandler(this.btnAzuriranje_Click);
            // 
            // btnNarucivanje
            // 
            this.btnNarucivanje.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNarucivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarucivanje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNarucivanje.Location = new System.Drawing.Point(492, 524);
            this.btnNarucivanje.Name = "btnNarucivanje";
            this.btnNarucivanje.Size = new System.Drawing.Size(121, 56);
            this.btnNarucivanje.TabIndex = 15;
            this.btnNarucivanje.Text = "Naručivanje";
            this.btnNarucivanje.UseVisualStyleBackColor = false;
            this.btnNarucivanje.Click += new System.EventHandler(this.btnNarucivanje_Click);
            // 
            // dgvPregledNarudzbi
            // 
            this.dgvPregledNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledNarudzbi.Location = new System.Drawing.Point(40, 190);
            this.dgvPregledNarudzbi.Name = "dgvPregledNarudzbi";
            this.dgvPregledNarudzbi.ReadOnly = true;
            this.dgvPregledNarudzbi.RowHeadersWidth = 51;
            this.dgvPregledNarudzbi.RowTemplate.Height = 24;
            this.dgvPregledNarudzbi.Size = new System.Drawing.Size(871, 328);
            this.dgvPregledNarudzbi.TabIndex = 14;
            this.dgvPregledNarudzbi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregledNarudzbi_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCVZ_Menza_.Properties.Resources.Dizajn_bez_naslova_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(509, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pretraživanje naziva obroka:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmPretrazivanjeNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(948, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnAzuriranje);
            this.Controls.Add(this.btnNarucivanje);
            this.Controls.Add(this.dgvPregledNarudzbi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPretrazivanjeNarudzbi";
            this.Text = "FrmPretrazivanjeNarudzbi";
            this.Load += new System.EventHandler(this.FrmPretrazivanjeNarudzbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledNarudzbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnAzuriranje;
        private System.Windows.Forms.Button btnNarucivanje;
        private System.Windows.Forms.DataGridView dgvPregledNarudzbi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}