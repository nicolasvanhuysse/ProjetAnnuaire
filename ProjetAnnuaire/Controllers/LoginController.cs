using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetAnnuaire.Services;

namespace ProjetAnnuaire.Controllers
{
    public class LoginController : Controller
    {
        private ILogin _login;

        public LoginController(ILogin login)
        {
            _login = login;
        }
        // GET: /<controller>/
        public IActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        public IActionResult SubmitLogin(string login, string password)
        {
            if (_login.LogIn(login, password))
            {
                return RedirectToAction("Admin", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Login", new { message = "Erreur de connexion" });
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
