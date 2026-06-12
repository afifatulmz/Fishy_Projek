using System;
using Fishy_Projek.Helpers;
using Fishy_Projek.Models;
using Npgsql;

namespace Fishy_Projek.Controllers
{
    public class AuthController
    {
        
        public User ValidasiLogin(string usernameInput, string passwordUser)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_user, nama, username, password, id_role FROM users WHERE nama = @nama AND password = @pass";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", usernameInput);
                    cmd.Parameters.AddWithValue("@pass", passwordUser);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idUser = reader.GetInt32(0);
                            string nama = reader.GetString(1);
                            string username = reader.GetString(2);
                            string pass = reader.GetString(3);
                            int idRole = reader.GetInt32(4);

                            
                            if (idRole == 1)
                                return new Manager(idUser, nama, pass, idRole);
                            else
                                return new Operator(idUser, nama, pass, idRole);
                        }
                    }
                }
            }
            return null; 
        }
    }
}