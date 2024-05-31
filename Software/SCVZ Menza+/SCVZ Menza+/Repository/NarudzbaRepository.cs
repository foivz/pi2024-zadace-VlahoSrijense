﻿using DBLayer;
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
        public static float NadiCijenu(int id)
        {
            string sql = $"SELECT Cijena FROM dbo.Obrok WHERE IdObroka = {id}";
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

        public static void InsertNarudzba(int idObroka, int kolicina, string ukupnaCijena, string statusNarudzbe, string vrijemeNarudzbe)
        {
            string sql = $"INSERT INTO dbo.Narudzba (IdObrok, Kolicina, UkupnaCijena, StatusNarudzbe, VrijemeNarudzbe) VALUES ('{idObroka}', '{kolicina}', '{ukupnaCijena}', '{statusNarudzbe}', '{vrijemeNarudzbe}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
