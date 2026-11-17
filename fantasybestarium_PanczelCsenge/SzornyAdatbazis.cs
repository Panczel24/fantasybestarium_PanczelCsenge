using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace fantasybestarium_PanczelCsenge
{
    public class SzornyAdatbazis
    {
        private readonly string connectionString;
        //List<Szorny> Szornyek = new List<Szorny>();


        public  List<Szorny> Feltolt( string connectionString)
        {
            //connectionString = "server=localhost; " +
            //    "database=fantasybestariumdb; uid=root; password=";
            List<Szorny> szornyek = new List<Szorny>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM `szornyek`";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Szorny szorny = new Szorny(
                                Convert.ToInt16(reader["Id"]),
                                reader["Nev"].ToString(),
                                Convert.ToInt16(reader["VeszelyessegiSzint"]),
                                reader["Elohely"].ToString(),
                                reader["FoGyengeseg"].ToString(),
                                reader["LeggyakoribbZsakmany"].ToString(),
                                Convert.ToBoolean(reader["VeszelyesE"])
                            );

                            szornyek.Add(szorny);
                        }
                    }
                }
            }

            return szornyek;
        }
    }
}
