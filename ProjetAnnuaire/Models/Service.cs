using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetAnnuaire.Models
{
    public class Service
    {
        private int idService;
        private string name;

        private static string request;
        private static MySqlCommand command;
        private static MySqlConnection connection;
        private static MySqlDataReader reader;

        public Service()
        {
        }

        public int IdService { get => idService; set => idService = value; }
        public string Name { get => name; set => name = value; }

        // Add Service
        public bool Save()
        {
            request = "INSERT INTO service (name) values (@name); SELECT LAST_INSERT_ID()";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@name", Name));
            connection.Open();
            IdService = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
            return IdService > 0;
        }

        //Update Service
        public bool Update()
        {
            request = "Update service set name=@name where idService=@id";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", IdService));
            command.Parameters.Add(new MySqlParameter("@name", Name));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }

        //Delete Service
        public bool Delete()
        {
            request = "Select count(*) FROM employee where idService=@id";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", IdService));
            connection.Open();
            reader = command.ExecuteReader();
            int result = -1;
            if (reader.Read())
            {
                result = reader.GetInt32(0);
            };
            command.Dispose();
            connection.Close();

            if(result == 0)
            {
                request = "DELETE FROM service where idService=@id";
                connection = db.Connection;
                command = new MySqlCommand(request, connection);
                command.Parameters.Add(new MySqlParameter("@id", IdService));
                connection.Open();
                int nb = command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return nb == 1;
            }
            else
            {
                return result == 0;
            }
        }

        // Get by id Service
        public static Service GetService(int id)
        {
            Service service = null;
            request = "SELECT idService, name FROM service where idService = @id";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("id", id));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                service = new Service()
                {
                    IdService = reader.GetInt32(0),
                    Name = reader.GetString(1),
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return service;
        }

        // Liste des Services
        public static List<Service> GetServices()
        {
            List<Service> services = new List<Service>();
            request = "SELECT idService, name FROM service";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Service service = new Service()
                {
                    IdService = reader.GetInt32(0),
                    Name = reader.GetString(1),

                };
                services.Add(service);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return services;
        }
    }
}
