using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace oti2018_national
{
    public class DataAccess
    {
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Proiecte C#\\Proiecte\\oti2018_national\\oti2018_national\\Data\\CentenarDB.mdf\";Integrated Security=True";
        public void LoadData()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                Clear(con);

                string filepathUtilizatori = "utilizatori.txt";
                string filepathLectii = "lectii.txt";

                string cmdTextUtilizatori = "Insert into Utilizatori (nume, parola, email) values (@nume, @parola, @email)";
                string cmdTextLectii = "Insert into Lectii (idutilizator, numelectie, regiune, datacreare, numeimagine) values (@idutilizator, @numelectie, @regiune, @datacreare, @numeimagine)";

                using(StreamReader rdr = new StreamReader(filepathUtilizatori))
                {
                    var line = rdr.ReadLine().Split('*');
                    using(SqlCommand cmd = new SqlCommand(cmdTextUtilizatori, con))
                    {
                        cmd.Parameters.AddWithValue("nume", line[0]);
                        cmd.Parameters.AddWithValue("parola", line[1]);
                        cmd.Parameters.AddWithValue("email", line[2]);

                        cmd.ExecuteNonQuery();
                    }
                }

                using (StreamReader reader = new StreamReader(filepathLectii))
                {
                    var line = reader.ReadLine().Split('*');
                    using (SqlCommand cmd = new SqlCommand(cmdTextLectii, con))
                    {
                        cmd.Parameters.AddWithValue("idutilizator", line[0]);
                        cmd.Parameters.AddWithValue("numelectie", line[1]);
                        cmd.Parameters.AddWithValue("regiune", line[2]);
                        cmd.Parameters.AddWithValue("datacreare", line[4]);
                        cmd.Parameters.AddWithValue("numeimagine", line[3]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void Clear(SqlConnection con)
        {
            
            string cmdText = "Delete from Utilizatori";
            EndQuery(cmdText, con);
            cmdText = "Delete from Lectii";
        }

        private void EndQuery(string cmdText, SqlConnection con)
        {
            using(SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}