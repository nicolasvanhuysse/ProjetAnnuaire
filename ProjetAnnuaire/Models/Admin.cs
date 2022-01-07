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

        public static Admin GetAdminLogin2(string l, string p)
        {
            Admin admin = null;

            //Faire une compraison dans la base de données.
            //Pour simplifier le developpement, je fais une comparaison avec des données statiques.
            if(l == "toto" && p == "tata")
            {
                admin = new Admin()
                {
                    Login = l,
                    Password = p
                };
              
            }
            return admin;
        }

        //methode qui récupére les saisies du formulaire de connexion et verifie la validité des informations dans la base de données
        public static Admin GetAdminLogin3(string login, string password)
        {
            Admin admin = null;
            //Faire un select si le mot de passe et le login correspondent à ceux dans la base de données.
            request = "SELECT password FROM admin WHERE login = @Login";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("Login", login));

            connection.Open();
            MySqlDataReader passwordHash = command.ExecuteReader();
            passwordHash.Read();

            //S'il y a eu une erreur lors de la saisie du login, le résultat de la requête sql lèvera une exception
            try
            {
                String SavedPasswordHash = passwordHash["Password"].ToString();

                //Vérifier si le mot de passe correspond à celui de la base de données
                byte[] hashBytes = Convert.FromBase64String(SavedPasswordHash);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
                byte[] hash = pbkdf2.GetBytes(20);

                for (int i = 0; i < 20; i++)
                    if (hashBytes[i + 16] == hash[i])
                    {
                        admin = new Admin()
                        {
                            Login = login,
                            Password = password,
                        };

                    }
            }
            //En cas d'erreur sur le login saisi, la variable user restera à sa valeur initiale "null" et la vue renverra un message d'erreur
            catch (MySqlException)
            {

            }
            catch (ArgumentNullException)
            {

            }
            command.Dispose();
            connection.Close();

            return admin;
        }



        public static Admin GetAdminLogin(string login, string password)
        {
            Admin admin = null;
            //Faire un select si le mot de passe et le login correspondent à ceux dans la base de données.
            request = "SELECT Count(*) FROM admin WHERE login = @Login AND password = @Password ";
            connection = db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("Login", login));

            // REVOIR LE SYSTEME ? POURQUOI HASHAGE ? ET IL NECESSAIRE ?
/*            //Hashage du mot de passe
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            string PasswordHash = Convert.ToBase64String(hashBytes);*/
            command.Parameters.Add(new MySqlParameter("Password", password));
            connection.Open();
            //vérifier si le login et le mot de passe sont présents dans la base de données
            //Faire une compraison dans la base de données.
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count == 1)
            {
                admin = new Admin()
                {
                    Login = login ,
                    Password = password
                };
            }
            command.Dispose();
            connection.Close();

            return admin;
        }
    }
}
