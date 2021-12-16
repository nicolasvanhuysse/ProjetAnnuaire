using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetAnnuaire.Models
{
    public class SiteType
    {
        private int id_SiteType;
        private string name;

        private static string request;
        private static MySqlCommand command;
        private static MySqlConnection connection;
        private static MySqlDataReader reader;

        public SiteType()
        {
        }

        public string Name { get => name; set => name = value; }
        public int Id_SiteType { get => id_SiteType; set => id_SiteType = value; }

        // Get by id SiteType
        public static SiteType GetSiteType(int id)
        {
            SiteType siteType = null;
            request = "SELECT id_SiteType, name FROM sitetype where id_SiteType = @id";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("id", id));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                siteType = new SiteType()
                {
                    Id_SiteType = reader.GetInt32(0),
                    Name = reader.GetString(1),
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return siteType;
        }

        // Liste des SiteTypes
        public static List<SiteType> GetSiteTypes()
        {
            List<SiteType> siteTypes = new List<SiteType>();
            request = "SELECT id_SiteType, name FROM sitetype";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                SiteType siteType = new SiteType()
                {
                    Id_SiteType = reader.GetInt32(0),
                    Name = reader.GetString(1),
                };
                siteTypes.Add(siteType);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return siteTypes;

        }
    }
}
