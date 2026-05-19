using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace EcoDrive.Helpers
{
    class DatabaseHelper
    {
        private static string connString = "Host=localhost;Port=5432;Database=KoneksiDB;Username=postgres;Password=langgeng847";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
