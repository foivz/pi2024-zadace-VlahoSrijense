using DBLayer;
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
        public FrmAzuriranje()
        {
            InitializeComponent();
            LoadObroci();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {

        }

        private void FrmAzuriranje_Load(object sender, EventArgs e)
        {

        }

        private void cboObrok_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtKolicina_TextChanged_1(object sender, EventArgs e)
        {

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
