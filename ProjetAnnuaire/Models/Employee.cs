using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProjetAnnuaire.Models
{
    public class Employee
    {
        private int id;
        private string firstname;
        private string lastname;
        private string phone;
        private string cellphone;
        private string mail;
        private Site site;
        private Service service;

        private static string request;
        private static MySqlCommand command;
        private static MySqlConnection connection;
        private static MySqlDataReader reader;

        public Employee()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Cellphone { get => cellphone; set => cellphone = value; }
        public string Mail { get => mail; set => mail = value; }
        public Site Site { get => site; set => site = value; }
        public Service Service { get => service; set => service = value; }

        // Add Salarié
        public bool Save()
        {
            request = "INSERT INTO employee (lastname, firstname, phone, cellphone, mail, idSite, idService) values (@lastname, @firstname, @phone, @cellphone, @mail, @idSite, @idService); SELECT LAST_INSERT_ID()";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@lastname", Lastname));
            command.Parameters.Add(new MySqlParameter("@firstname", Firstname));
            command.Parameters.Add(new MySqlParameter("@phone", Phone));
            command.Parameters.Add(new MySqlParameter("@cellphone", Cellphone));
            command.Parameters.Add(new MySqlParameter("@mail", Mail));
            command.Parameters.Add(new MySqlParameter("@idSite", Site.IdSite));
            command.Parameters.Add(new MySqlParameter("@idService", Service.IdService));
            connection.Open();
            Id = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        //Update Salarié
        public bool Update()
        {
            request = "Update employee set lastname=@lastname, firstname=@firstname, phone=@phone, cellphone=@cellphone, mail=@mail, idSite=@idSite, idService=@idService where id=@id";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", Id));
            command.Parameters.Add(new MySqlParameter("@lastname", Lastname));
            command.Parameters.Add(new MySqlParameter("@firstname", Firstname));
            command.Parameters.Add(new MySqlParameter("@phone", Phone));
            command.Parameters.Add(new MySqlParameter("@cellphone", Cellphone));
            command.Parameters.Add(new MySqlParameter("@mail", Mail));
            command.Parameters.Add(new MySqlParameter("@idSite", Site.IdSite));
            command.Parameters.Add(new MySqlParameter("@idService", Service.IdService));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }

        //Delete Salarié
        public bool Delete()
        {
            request = "DELETE FROM employee where id=@id";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", Id));
            connection.Open();
            int nb = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nb == 1;
        }

        // Liste des Salarié
        public static List<Employee> GetEmployees( string condition = "" )
        {
            List<Employee> employees = new List<Employee>();
            request = "SELECT id, firstname, lastname, phone, cellphone, mail, idSite, idService FROM employee";
            if (condition != "")
            {
                request += " WHERE " + condition;
            };
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee()
                {
                    Id = reader.GetInt32(0),
                    Firstname = reader.GetString(1),
                    Lastname = reader.GetString(2),
                    Phone = reader.GetString(3),
                    Cellphone = reader.GetString(4),
                    Mail = reader.GetString(5),
                    Site = Site.GetSite(reader.GetInt32(6)),
                    Service = Service.GetService(reader.GetInt32(7))
                };
                employees.Add(employee);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return employees;

        }

        // Get by id Salarié
        public static Employee GetEmployee(int id)
        {
            Employee employee = null;
            request = "SELECT id, firstname, lastname, phone, cellphone, mail, idSite, idService FROM employee where id = @id";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("id", id));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                employee = new Employee()
                {
                    Id = reader.GetInt32(0),
                    firstname = reader.GetString(1),
                    lastname = reader.GetString(2),
                    phone = reader.GetString(3),
                    cellphone = reader.GetString(4),
                    mail = reader.GetString(5),
                    Site = Site.GetSite(reader.GetInt32(6)),
                    Service = Service.GetService(reader.GetInt32(7))
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return employee;
        }
    }
}
