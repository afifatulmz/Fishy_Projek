using System;
using Npgsql;

namespace Fishy_Projek.Helpers
{
    public static class DbHelper
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=Desember25;Database=db_fishy";
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
