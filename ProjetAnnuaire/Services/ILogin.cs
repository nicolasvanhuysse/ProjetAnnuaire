using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAnnuaire.Services
{
    public interface ILogin
    {
        bool isLogged();
        string GetLogin();
        bool LogIn(string login, string password);
    }
}
