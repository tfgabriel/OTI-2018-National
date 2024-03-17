using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace oti2018_national
{
    public class DataManagement
    {
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Proiecte C#\\Proiecte\\oti2018_national\\oti2018_national\\Data\\CentenarDB.mdf\";Integrated Security=True";
        public UserModel checkuserindb(UserModel user)
        {
            
            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Select email, parola from Utilizatori where email = @email";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("email", user.email);
                    using(SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if(rdr.Read())
                        {
                            user.password = (string)rdr["parola"];
                            return user;
                        }
                        else
                        {
                            MessageBox.Show("esti bou");
                            return null;
                        }
                    }
                }
            }      
        }

        public List<LectieModel> getlectii()
        {
            List<LectieModel> lectii = new List<LectieModel>();
            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Select idutilizator, numelectie, regiune, datacreare, numeimagine from Lectii";

                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    using(SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            lectii.Add(new LectieModel
                            { 
                                id_util = (int)rdr["idutilizator"],
                                nume = (string)rdr["numelectie"],
                                regiune = (string)rdr["regiune"],
                                datacrearii = (DateTime)rdr["datacreare"],
                                imagine = (string)rdr["numeimagine"]
                            });
                        }
                    }
                }
            }

            return lectii;
        }

        public UserModel getlessonowner(int id_util)
        {
            UserModel user = new UserModel();

            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Select email, nume from Utilizatori where Id = @id";
                
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("id", id_util);
                    using(SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if(rdr.Read())
                        {
                            user = new UserModel{
                                email = (string)rdr["email"],
                                nume = (string)rdr["nume"]
                            };
                        }
                    }
                }
            }

            return user;
        }

        public void changepass(string email, string newpass)
        {
            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Update Utilizatori set parola = @newparola where email = @email";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue ("email", email);
                    cmd.Parameters.AddWithValue("newparola", newpass);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}