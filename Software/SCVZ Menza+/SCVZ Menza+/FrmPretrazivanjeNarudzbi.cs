using SCVZ_Menza_.Models;
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
            var narudzba = NarudzbaRepository.GetNarudzba();
            dgvPregledNarudzbi.DataSource = narudzba;

            dgvPregledNarudzbi.AutoGenerateColumns = true;  
        }

        private void ShowTrazeneNarudzbe()
        {
            List<Narudzba> narudzba = NarudzbaRepository.SearchNarudzba(txtPretrazivanje.Text);
            dgvPregledNarudzbi.DataSource = narudzba;

            dgvPregledNarudzbi.AutoGenerateColumns = true;

        }


        private void txtPretrazivanje_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pretrazivanje = txtPretrazivanje.Text;
            if (pretrazivanje != null)
            {
                ShowTrazeneNarudzbe();
            }

        }

        private void dgvPregledNarudzbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNarucivanje_Click(object sender, EventArgs e)
        {

            FrmNarudzba frmNarudzba = new FrmNarudzba();
            Hide();
            frmNarudzba.ShowDialog();
            Close();

     
        }

        private void btnAzuriranje_Click(object sender, EventArgs e)
        {
            Narudzba selectedNarudzba = dgvPregledNarudzbi.CurrentRow.DataBoundItem as Narudzba;
            if (selectedNarudzba != null)
            {
                FrmAzuriranje frmAzuriranje = new FrmAzuriranje();
                Hide();
                frmAzuriranje.ShowDialog();
                Close();
            }
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            Narudzba selectedNarudzba = dgvPregledNarudzbi.CurrentRow.DataBoundItem as Narudzba;
            if (selectedNarudzba != null)
            {
                int idNarudzbe = selectedNarudzba.IdNarudzbe;
                string sql = $"DELETE FROM dbo.Narudzba WHERE IdNarudzbe={idNarudzbe}";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                ShowNarudzbe();
            }

        }

        private void FrmPretrazivanjeNarudzbi_Load(object sender, EventArgs e)
        {

        }
    }
}
