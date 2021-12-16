using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetAnnuaire.Models
{
    public class Admin
    {
        private int id;
        private string login;
        private string password;

        public Admin()
        {
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public static Admin GetAdminLogin(string l, string p)
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
    }
}
