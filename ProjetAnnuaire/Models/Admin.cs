using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Session;

namespace ProjetAnnuaire.Models
{
    public class Admin
    {
        private int id;
        private string login;
        private string password;

        private static string request;
        private static MySqlConnection connection;
        private static MySqlCommand command;

        public Admin()
        {
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        //methode qui récupére les saisies du formulaire de connexion et verifie la validité des informations dans la base de données

        public static Admin GetAdminLogin(string login, string password)
        {
            Admin admin = null;
            //Faire un select si le mot de passe et le login correspondent à ceux dans la base de données.
            request = "SELECT password FROM admin WHERE login = @Login";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("Login", login));


            //command.Parameters.Add(new MySqlParameter("Password", password));
            connection.Open();
            MySqlDataReader passwordHash = command.ExecuteReader();
            passwordHash.Read();
            String SavedPasswordHash = passwordHash["Password"].ToString();

            //Vérifier si le mot de passe correspond à celui de la base de données

            var hashedPassword = Sha256encrypt(password);

            string sHashedPasswrord = hashedPassword.ToString();
            if (sHashedPasswrord == SavedPasswordHash )
            {
                admin = new Admin()
                {
                    Login = login,
                    Password = password
                };

            }

            command.Dispose();
            connection.Close();
            return admin;
        }

        private static object Sha256encrypt(string password)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(password));
            return Convert.ToBase64String(hashedDataBytes);
        }
    }
}
