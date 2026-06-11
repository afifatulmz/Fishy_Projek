using System;
using System.Collections.Generic;
using System.Text;

namespace Fishy_Projek
{
    public static class DbHelper
    {
        private static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=fishy_db";
        public static npgsqlConnection GetConnection()
        {
            return new npgsqlConnection(connectionString);
        }
    }
}
