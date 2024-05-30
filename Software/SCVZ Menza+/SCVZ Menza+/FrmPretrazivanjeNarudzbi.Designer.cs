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
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.btnAzuriranje = new System.Windows.Forms.Button();
            this.btnNarucivanje = new System.Windows.Forms.Button();
            this.dgvPregledNarudzbi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledNarudzbi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(598, 24);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(99, 31);
            this.btnPretrazi.TabIndex = 20;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(332, 29);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(248, 22);
            this.txtPretrazivanje.TabIndex = 19;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pregled Narudžbi:";
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(396, 366);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(121, 56);
            this.btnBrisanje.TabIndex = 17;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // btnAzuriranje
            // 
            this.btnAzuriranje.Location = new System.Drawing.Point(247, 366);
            this.btnAzuriranje.Name = "btnAzuriranje";
            this.btnAzuriranje.Size = new System.Drawing.Size(121, 56);
            this.btnAzuriranje.TabIndex = 16;
            this.btnAzuriranje.Text = "Ažuriranje";
            this.btnAzuriranje.UseVisualStyleBackColor = true;
            this.btnAzuriranje.Click += new System.EventHandler(this.btnAzuriranje_Click);
            // 
            // btnNarucivanje
            // 
            this.btnNarucivanje.Location = new System.Drawing.Point(99, 366);
            this.btnNarucivanje.Name = "btnNarucivanje";
            this.btnNarucivanje.Size = new System.Drawing.Size(121, 56);
            this.btnNarucivanje.TabIndex = 15;
            this.btnNarucivanje.Text = "Naručivanje";
            this.btnNarucivanje.UseVisualStyleBackColor = true;
            this.btnNarucivanje.Click += new System.EventHandler(this.btnNarucivanje_Click);
            // 
            // dgvPregledNarudzbi
            // 
            this.dgvPregledNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledNarudzbi.Location = new System.Drawing.Point(99, 106);
            this.dgvPregledNarudzbi.Name = "dgvPregledNarudzbi";
            this.dgvPregledNarudzbi.RowHeadersWidth = 51;
            this.dgvPregledNarudzbi.RowTemplate.Height = 24;
            this.dgvPregledNarudzbi.Size = new System.Drawing.Size(605, 239);
            this.dgvPregledNarudzbi.TabIndex = 14;
            this.dgvPregledNarudzbi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregledNarudzbi_CellContentClick);
            // 
            // FrmPretrazivanjeNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnAzuriranje);
            this.Controls.Add(this.btnNarucivanje);
            this.Controls.Add(this.dgvPregledNarudzbi);
            this.Name = "FrmPretrazivanjeNarudzbi";
            this.Text = "FrmPretrazivanjeNarudzbi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledNarudzbi)).EndInit();
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
    }
}