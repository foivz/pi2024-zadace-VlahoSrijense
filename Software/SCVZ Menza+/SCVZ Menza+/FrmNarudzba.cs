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
    public partial class FrmNarudzba : Form
    {
        public FrmNarudzba()
        {
            InitializeComponent();
            GenerateNextOrderId();
            LoadObroci();
            txtVrijemeNarudzbe.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtStatusNarudzbe.Text = "Naručivanje";

        }
        private void FrmNarudzba_Load(object sender, EventArgs e)
        {
        }

        private void txtStatusNarudzbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            int idObroka = idOdabranogObroka;
            int kolicina = int.Parse(txtKolicina.Text);
            string ukupnaCijena = txtUkupnaCijena.Text;
            string statusNarudzbe = "U pripremi";
            string vrijemeNarudzbe = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            NarudzbaRepository.InsertNarudzba(idObroka, kolicina, ukupnaCijena, statusNarudzbe, vrijemeNarudzbe);

            FrmPretrazivanjeNarudzbi frmPretrazivanjeNarudzbi = new FrmPretrazivanjeNarudzbi();
            Hide();
            frmPretrazivanjeNarudzbi.ShowDialog();
            Close();
        }

        private void txtVrijemeNarudzbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
          
                FrmPretrazivanjeNarudzbi frmPretrazivanjeNarudzbi = new FrmPretrazivanjeNarudzbi();
                Hide();
                frmPretrazivanjeNarudzbi.ShowDialog();
                Close();
        }

        private void txtKolicina_TextChanged(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtUkupnaCijena_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboObrok_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        int idOdabranogObroka;
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

            idOdabranogObroka = (int)cboObrok.SelectedValue;

            reader.Close();
  
                DB.CloseConnection();
        }

        private void GenerateNextOrderId()
        {
                int maxOrderId = NarudzbaRepository.GetMaxOrderId();

                int nextOrderId = maxOrderId + 1;

                txtBrojNarudžbe.Text = nextOrderId.ToString();
            }

    }
}

