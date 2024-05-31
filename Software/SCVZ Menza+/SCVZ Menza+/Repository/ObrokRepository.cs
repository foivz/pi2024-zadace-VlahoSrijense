using DBLayer;
using SCVZ_Menza_.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ_Menza_.Repository
{
    public class ObrokRepository
    {
        public static Obrok GetObrok(int id)
        {
            Obrok obrok = null;

            string sql = "SELECT * FROM dbo.Obrok WHERE IdObroka = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                obrok = CreateObject(reader);
                reader.Close();
            }


            DB.CloseConnection();

            return obrok;
        }

        public static List<Obrok> GetObroke()
        {
            var obroci = new List<Obrok>();

            string sql = "SELECT * FROM dbo.Obrok";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Obrok obrok = CreateObject(reader);
               obroci.Add(obrok);
            }
            reader.Close();

            DB.CloseConnection();

            return obroci;
        }


        private static Obrok CreateObject(SqlDataReader reader)
        {
            int idObroka = int.Parse(reader["IdObrok"].ToString());
            string nazivObroka = reader["NazivObroka"].ToString();
            string opisObroka = reader["OpisObroka"].ToString();
            int zaliha = int.Parse(reader["Zaliha"].ToString());
            float cijena = float.Parse(reader["Cijena"].ToString());


            var obrok = new Obrok
            {
                IdObroka = idObroka,
                NazivObroka = nazivObroka,
                OpisObroka = opisObroka,
                Zaliha = zaliha,
                Cijena = cijena,
   
            };
            return obrok;
        }
    }
}
