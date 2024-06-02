using DBLayer;
using SCVZ_Menza_.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCVZ_Menza_.Repository
{
    public class NarudzbaRepository
    {
        public static List<Narudzba> GetNarudzba()
        {
            var narudzbe = new List<Narudzba>();

            string sql = $"SELECT n.IdNarudzbe, n.IdObrok, o.NazivObroka, n.Kolicina, n.UkupnaCijena, n.StatusNarudzbe, n.VrijemeNarudzbe FROM dbo.Narudzba n JOIN dbo.Obrok o ON n.IdObrok = o.IdObroka";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Narudzba narudzba = CreateObject(reader);
                narudzbe.Add(narudzba);
            }
            reader.Close();

            DB.CloseConnection();
      
            return narudzbe;
        }

        public static List<Narudzba> SearchNarudzba(string pretrazivanje)
        {
            var narudzbe = new List<Narudzba>();

            string sql = $@"
                SELECT n.IdNarudzbe, n.IdObrok, o.NazivObroka, n.Kolicina, n.UkupnaCijena, n.StatusNarudzbe, n.VrijemeNarudzbe
                FROM dbo.Narudzba n
                JOIN dbo.Obrok o ON n.IdObrok = o.IdObroka
                WHERE o.NazivObroka LIKE '%{pretrazivanje}%'"; ;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Narudzba narudzba = CreateObject(reader);
                narudzbe.Add(narudzba);
            }
            reader.Close();

            DB.CloseConnection();

            return narudzbe;
        }

        private static Narudzba CreateObject(SqlDataReader reader)
        {
            int idNarudzbe = int.Parse(reader["IdNarudzbe"].ToString());
            int idObroka = int.Parse(reader["IdObrok"].ToString());
            string nazivObroka = reader["NazivObroka"].ToString();
            int kolicina = int.Parse(reader["Kolicina"].ToString());
            float cijena = float.Parse(reader["UkupnaCijena"].ToString());
            string statusNarudzbe = reader["StatusNarudzbe"].ToString();
            DateTime vrijemeNarudzbe = DateTime.Parse(reader["VrijemeNarudzbe"].ToString());
           

            var narudzba = new Narudzba
            {
                IdNarudzbe = idNarudzbe,
                IdObroka = idObroka,
                NazivObroka = nazivObroka,
                Kolicina = kolicina,
                UkupnaCijena = cijena,
                StatusNarudzbe = statusNarudzbe,
                VrijemeNarudzbe = vrijemeNarudzbe
               
            };
            return narudzba;
        }
        public static int GetMaxOrderId()
        {
            string sql = $"SELECT IdNarudzbe FROM dbo.Narudzba";
            int maxOrderId = 0;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                maxOrderId ++;
            }
            reader.Close(); 

            DB.CloseConnection();

            return maxOrderId;
        }
        public static float NadiCijenu(string naziv)
        {
            string sql = $"SELECT Cijena FROM dbo.Obrok WHERE NazivObroka = '{naziv}'";
            float cijena=0;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                cijena = float.Parse(reader["Cijena"].ToString()); ;
            }
            reader.Close();

            DB.CloseConnection();

            return cijena;
        }

        public static bool NadiZalihu(string naziv)
        {
            string sql = $"SELECT Zaliha FROM dbo.Obrok WHERE NazivObroka = '{naziv}'";
            int zaliha = 0;
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                zaliha = int.Parse(reader["Zaliha"].ToString()); ;
            }
            reader.Close();

            DB.CloseConnection();

            if(zaliha==0) return true;
            else return false;
        }

        public static int NadiIdObroka(string naziv)
        {
            int id = 0;
            string sql = $"SELECT IdObroka FROM dbo.Obrok WHERE NazivObroka = '{naziv}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                id = int.Parse(reader["IdObroka"].ToString());
              
            }
            reader.Close();

            DB.CloseConnection();

            return id;
        }

        public static string NadiNazivObroka(int id)
        {
            string nazivObroka ="";
            string sql = $"SELECT NazivObroka FROM dbo.Obrok WHERE IdObroka = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                nazivObroka = reader["NazivObroka"].ToString();
            }
            reader.Close();

            DB.CloseConnection();

            return nazivObroka;
        }

        public static void InsertNarudzba(int idNarudzbe, int idObroka, int kolicina, string ukupnaCijena, string statusNarudzbe, string vrijemeNarudzbe)
        {
            string sql = $"INSERT INTO dbo.Narudzba (IdNarudzbe, IdObrok, Kolicina, UkupnaCijena, StatusNarudzbe, VrijemeNarudzbe) VALUES ('{idNarudzbe}','{idObroka}', '{kolicina}', '{ukupnaCijena}', '{statusNarudzbe}', '{vrijemeNarudzbe}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void UpdateNarudzba(int idNarudzbe, int idObroka, int kolicina, string ukupnaCijena, string statusNarudzbe, string vrijemeNarudzbe)
        {
            string sql = $"UPDATE dbo.Narudzba SET IdNarudzbe='{idNarudzbe}', IdObrok='{idObroka}', Kolicina='{kolicina}', UkupnaCijena= '{ukupnaCijena}', StatusNarudzbe='{statusNarudzbe}', VrijemeNarudzbe='{vrijemeNarudzbe}' WHERE IdNarudzbe = {idNarudzbe}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
