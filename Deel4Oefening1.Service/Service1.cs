using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Deel4Oefening1.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        public List<Boete> GetBoetes()
        {
            List<Boete> boetes = new List<Boete>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM Boetes", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    boetes.Add(new Boete { Betalingsnr = int.Parse(reader["BETALINGSNR"].ToString()), Bedrag = decimal.Parse(reader["BEDRAG"].ToString()), Datum = DateTime.Parse(reader["DATUM"].ToString()), Spelersnr = int.Parse(reader["SPELERSNR"].ToString()) });
                }
                return boetes;
            }
        }
    }
}
