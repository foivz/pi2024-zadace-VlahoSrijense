using DBLayer;
using SCVZ_Menza_.Models;
using SCVZ_Menza_.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ_Menza_
{
    public partial class FrmAzuriranje : Form
    {
        private Narudzba narudzba;

        public Narudzba SelectedNarudzba { get => narudzba; set => narudzba = value; }
        public FrmAzuriranje(Narudzba selectedNarudzba)
        {
            InitializeComponent();
            LoadObroci();
           SelectedNarudzba = selectedNarudzba;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int idNarudzbe = int.Parse(txtBrojNarudžbe.Text);
            int idObroka = NarudzbaRepository.NadiIdObroka(idOdabranogObroka);
            int kolicina = int.Parse(txtKolicina.Text);
            string ukupnaCijena = txtUkupnaCijena.Text;
            string statusNarudzbe = "U pripremi";
            string vrijemeNarudzbe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            NarudzbaRepository.UpdateNarudzba(idNarudzbe, idObroka, kolicina, ukupnaCijena, statusNarudzbe, vrijemeNarudzbe);

            FrmPretrazivanjeNarudzbi frmPretrazivanjeNarudzbi = new FrmPretrazivanjeNarudzbi();
            Hide();
            frmPretrazivanjeNarudzbi.ShowDialog();
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmPretrazivanjeNarudzbi frmPretrazivanjeNarudzbi = new FrmPretrazivanjeNarudzbi();
            Hide();
            frmPretrazivanjeNarudzbi.ShowDialog();
            Close();
        }

        private void FrmAzuriranje_Load(object sender, EventArgs e)
        {
            int brojNarudzbe = SelectedNarudzba.IdNarudzbe;
            int idObroka = SelectedNarudzba.IdObroka;
            int kolicina = SelectedNarudzba.Kolicina;
            float cijena = SelectedNarudzba.UkupnaCijena;
            string statusNarudzbe = SelectedNarudzba.StatusNarudzbe;
            DateTime vrijemeNarudzbe = SelectedNarudzba.VrijemeNarudzbe;

            txtBrojNarudžbe.Text = brojNarudzbe.ToString();
            cboObrok.Text = NarudzbaRepository.NadiNazivObroka(idObroka);
            txtKolicina.Text = kolicina.ToString();
            txtUkupnaCijena.Text = cijena.ToString();
            txtStatusNarudzbe.Text = statusNarudzbe;
            txtVrijemeNarudzbe.Text = vrijemeNarudzbe.ToString();

        }
        string idOdabranogObroka;
        private void cboObrok_SelectedIndexChanged(object sender, EventArgs e)
        {
            idOdabranogObroka = cboObrok.Text.ToString();

        }

        private void txtKolicina_TextChanged_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtKolicina.Text, out int kolicina))
            {
                MessageBox.Show("Unesite valjanu količinu.");
                return;
            }
            if (cboObrok.SelectedItem == null)
            {
                MessageBox.Show("Odaberite obrok.");
                return;
            }



            float cijenaObroka = NarudzbaRepository.NadiCijenu(idOdabranogObroka);

            float ukupnaCijena = kolicina * cijenaObroka;

            txtUkupnaCijena.Text = ukupnaCijena.ToString();
        }

        private void txtUkupnaCijena_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtVrijemeNarudzbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStatusNarudzbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrojNarudžbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     
        private void LoadObroci()
        {
            DB.OpenConnection();
            string sql = "SELECT IdObroka, NazivObroka FROM dbo.Obrok";
            SqlDataReader reader = DB.GetDataReader(sql);

            DataTable dt = new DataTable();
            dt.Load(reader);

            cboObrok.DisplayMember = "NazivObroka";
            cboObrok.ValueMember = "IdObroka";
            cboObrok.DataSource = dt;
            reader.Close();

            DB.CloseConnection();
        }
    }
}
