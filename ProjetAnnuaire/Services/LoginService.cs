using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetAnnuaire.Models;
using Microsoft.AspNetCore.Http;

namespace ProjetAnnuaire.Services
{
    public class LoginService : ILogin
    {
        private IHttpContextAccessor _accessor;
        public LoginService(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string GetLogin()
        {
            return _accessor.HttpContext.Session.GetString("login");
        }

        public bool isLogged()
        {
            string test = _accessor.HttpContext.Session.GetString("isLogged");
            return test == "true";
        }

        public bool LogIn(string login, string password)
        {
            Admin a = Admin.GetAdminLogin(login, password);
            if (a != null)
            {
                _accessor.HttpContext.Session.SetString("login", a.Login);
                _accessor.HttpContext.Session.SetString("isLogged", "true");
                return true;
            }
            return false;
        }
    }
}
