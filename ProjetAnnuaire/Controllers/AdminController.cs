using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetAnnuaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAnnuaire.Controllers
{
    public class AdminController : Controller
    {
        // Page Admin
        public IActionResult Admin()
        {
            return View();
        }

        //---------------------------------------------------------------------------------------------------------
        // ----------------------------------------------PARTIE SITE-----------------------------------------------
        //---------------------------------------------------------------------------------------------------------

        // Vue gestion des Sites en liste
        public IActionResult Sites(string message)
        {
            ViewBag.Message = message;
            return View(Site.GetSites());
        }

        // Vue pour ajouter et modifier un site
        public IActionResult AddSite(int id)
        {
            ViewBag.SiteType = SiteType.GetSiteTypes();
            if (id > 0)
            {
                ViewBag.Site = Site.GetSite(id);
            }
            return View();
        }

        // Formulaire Ajout Site
        public IActionResult SubmitAddFormSite(Site s, SiteType sitetype)
        {
            s.SiteType = sitetype;
            s.Save();
            return RedirectToAction("Sites");
        }

        // Formulaire Modification Site
        public IActionResult SubmitEditFormSite(Site s, SiteType sitetype)
        {
            s.SiteType = sitetype;
            s.Update();
            return RedirectToAction("Sites");
        }

        // Delete Site
        public IActionResult DeleteSite(int id)
        {
            Site site = Site.GetSite(id);
            if (site != null)
            {   
                bool delete = site.Delete();
                if (delete) 
                {
                    return RedirectToAction("Sites","Admin");
                }
                else
                {
                    return RedirectToAction("Sites", "Admin", new { message = "Suppression impossible. Un salarié est encore lié au site." });
                }
            }else
            {
                return RedirectToAction("Sites", "Admin");
            }
        }

        //---------------------------------------------------------------------------------------------------------
        // ----------------------------------------------PARTIE SERVICE--------------------------------------------
        //---------------------------------------------------------------------------------------------------------

        // Vue gestion des Services en liste
        public IActionResult Services(string message)
        {
            ViewBag.Message = message;
            return View(Service.GetServices());
        }

        // Vue pour ajouter et modifier un service
        public IActionResult AddService(int id)
        {
            if (id > 0)
            {
                ViewBag.Service = Service.GetService(id);
            }
            return View();
        }

        // Formulaire Ajout Service
        public IActionResult SubmitAddFormService(Service s)
        {
            s.Save();
            return RedirectToAction("Services");
        }

        // Formulaire Modification Service
        public IActionResult SubmitEditFormService(Service s)
        {
            s.Update();
            return RedirectToAction("Services");
        }

        // Delete Service
        public IActionResult DeleteService(int id)
        {
            Service service = Service.GetService(id);
            if (service != null)
            {
                bool delete = service.Delete();
                if (delete)
                {
                    return RedirectToAction("Services", "Admin");
                }
                else
                {
                    return RedirectToAction("Services", "Admin", new { message = "Suppression impossible. Un salarié est encore lié au service." });
                }
            }
            else
            {
                return RedirectToAction("Services", "Admin");
            }
        }

        //---------------------------------------------------------------------------------------------------------
        // ----------------------------------------------PARTIE SALARIE--------------------------------------------
        //---------------------------------------------------------------------------------------------------------

        // Vue gestion des Salariés en liste
        public IActionResult Employees()
        {
            return View(Employee.GetEmployees());
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

        // Formulaire Ajout Salarié
        public IActionResult SubmitAddFormEmployee(Employee e, Site site, Service service)
        {
            e.Site = site;
            e.Service = service;
            e.Save();
            return RedirectToAction("Employees");
        }

        // Formulaire Modification Salarié
        public IActionResult SubmitEditFormEmployee(Employee e, Site site, Service service)
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

    }
}
