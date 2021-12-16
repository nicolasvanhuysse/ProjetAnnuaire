using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetAnnuaire.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ProjetAnnuaire.ViewModels;

namespace ProjetAnnuaire.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Page Accueil avec la liste des Salariés
        public IActionResult Index(string condition = "")
        {   
            ViewBag.Employee = Employee.GetEmployees();
            ViewBag.Site = Site.GetSites();
            ViewBag.Service = Service.GetServices();
            if (condition != "")
            {
                return View(Employee.GetEmployees(condition));
            }
            else
            {
                return View(Employee.GetEmployees());
            }
        }

        // Filtre Liste des Salariés
        public IActionResult SubmitForm(string search = null, int idSite = 0, int idService = 0)
        {   
            string condition = "";
            if (search != null  )
            {
                condition += " lastname like '" + search + "%' ";
            };
            if (idSite > 0)
            {
                if (condition != "")
                {
                    condition += " AND ";
                };
                condition += " idSite = " + idSite;
            };
            if (idService > 0)
            {
                if (condition != "")
                {
                    condition += " AND ";
                };
                condition += " idService = " + idService;
            };

            return RedirectToAction("Index" ,new { @condition = condition });
        }
        // Formulaire Ajout Salarié
        public IActionResult SubmitAddForm(Employee e, Site site, Service service)
        {
            e.Site = site;
            e.Service = service;
            e.Save();
            return RedirectToAction("Employees");
        }        
        
        // Formulaire Modification Salarié
        public IActionResult SubmitEditForm(Employee e, Site site, Service service)
        {
            e.Site = site;
            e.Service = service;
            e.Update();
            return RedirectToAction("Employees");
        }

        // Delete Salarié
        public IActionResult DeleteEmployee(int id)
        {
            Employee employee = Employee.GetEmployee(id);
            if (employee != null)
            {
                employee.Delete();
            }
            return RedirectToAction("Employees");
        }

        // Vue pour ajouter et modifier un salarié
        public IActionResult AddEmployee(int id)
        {
            ViewBag.Site = Site.GetSites();
            ViewBag.Service = Service.GetServices();
            if (id > 0)
            {
                ViewBag.Employee = Employee.GetEmployee(id);
            }
            return View();
        }

        // Page Admin
        public IActionResult Admin()
        {
            return View();
        }

        // Vue pour 1 seul salarié
        public IActionResult ShowEmployee(int id)
        {
            return View(Employee.GetEmployee(id));
        }

        // Vue gestion des Salariés en liste
        public IActionResult Employees()
        {
            return View(Employee.GetEmployees());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
