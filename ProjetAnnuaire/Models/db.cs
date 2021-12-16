using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetAnnuaire.Models
{
    public class db
    {
        public db()
        {
        }

        private static string connectionString = "Server=127.0.0.1;DataBase=projet.net individuel;UserId=root;password=";
        public static MySqlConnection Connection { get => new MySqlConnection(connectionString); }
    }
}
