using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetAnnuaire.Models
{
    public class Site
    {
        private int idSite; 
        private string name;
        private SiteType siteType;

        private static string request;
        private static MySqlCommand command;
        private static MySqlConnection connection;
        private static MySqlDataReader reader;

        public Site()
        {
        }

        public string Name { get => name; set => name = value; }
        public SiteType SiteType { get => siteType; set => siteType = value; }
        public int IdSite { get => idSite; set => idSite = value; }

        // Add Site
        public bool Save()
        {
            request = "INSERT INTO site (name, id_SiteType) values (@name, @id_SiteType); SELECT LAST_INSERT_ID()";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@name", Name));
            command.Parameters.Add(new MySqlParameter("@id_SiteType", SiteType.Id_SiteType));
            connection.Open();
            IdSite = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
            return IdSite > 0;
        }

        //Update Site
        public bool Update()
        {
            request = "Update site set name=@name, id_SiteType=@id_SiteType where idSite=@idSite";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@idSite", IdSite));
            command.Parameters.Add(new MySqlParameter("@name", Name));
            command.Parameters.Add(new MySqlParameter("@id_SiteType", SiteType.Id_SiteType));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }

        //Delete Site
        public bool Delete()
        {
            request = "Select count(*) FROM employee where idSite=@id";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", IdSite));
            connection.Open();
            reader = command.ExecuteReader();
            int result = -1;
            if (reader.Read())
            {
                result = reader.GetInt32(0);
            };
            command.Dispose();
            connection.Close();

            if (result == 0)
            {
                request = "DELETE FROM site where idSite=@id";
                connection = db.Connection;
                command = new MySqlCommand(request, connection);
                command.Parameters.Add(new MySqlParameter("@id", IdSite));
                connection.Open();
                int nb = command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return nb == 1;
            }
            else
            {
                return result == 1;
            }
        }

        // Get by id Site
        public static Site GetSite(int id)
        {
            Site site = null;
            request = "SELECT idSite, name, id_SiteType FROM site where idSite = @id";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("id", id));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                site = new Site()
                {
                    IdSite = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    SiteType = SiteType.GetSiteType(reader.GetInt32(2))
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return site;
        }

        // Liste des Sites
        public static List<Site> GetSites()
        {
            List<Site> sites = new List<Site>();
            request = "SELECT idSite, name, id_SiteType FROM site";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Site site = new Site()
                {
                    IdSite = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    SiteType = SiteType.GetSiteType(reader.GetInt32(2))
                };
                sites.Add(site);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return sites;

        }
    }
}
