﻿using SCVZ_Menza_.Models;
using SCVZ_Menza_.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;


namespace SCVZ_Menza_
{
    public partial class FrmPretrazivanjeNarudzbi : Form
    {
        public FrmPretrazivanjeNarudzbi()
        {
            InitializeComponent();
            ShowNarudzbe();
        }
       
        private void ShowNarudzbe()
        {
            var students = NarudzbaRepository.GetNarudzba();
            dgvPregledNarudzbi.DataSource = students;

            dgvPregledNarudzbi.AutoGenerateColumns = true;  
        }

    private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

        }

        private void dgvPregledNarudzbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNarucivanje_Click(object sender, EventArgs e)
        {

        }

        private void btnAzuriranje_Click(object sender, EventArgs e)
        {

        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {

        }
    }
}
