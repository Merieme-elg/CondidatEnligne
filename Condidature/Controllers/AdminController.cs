using Condidature.DBContext;
using Condidature.Models;
using Condidature.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Condidature.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdmin _IAdmin;
        public AdminController(IAdmin IAdmin)
        {
            _IAdmin = IAdmin;
        }
        public IActionResult Index()
        {
     
            return View();
        }

        //list of condidats
        public IActionResult List()
        {
            List<Condidat> condidate = _IAdmin.GetCondidats();
            return View(condidate);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            _IAdmin.Delete(Id);
            //afficher un message de confirmation
            TempData["ConfirmationMessage"] = "Cet condidat à bien été supprimer.";
            //retourner vers la liste principal
            return RedirectToAction(nameof(List));

        }

        public IActionResult Recherche(string nom, string prenom, string email)
        {
            var condidatures = _IAdmin.Recherche(nom, prenom, email);
            return View("List",condidatures);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
                 // Vérifiez les informations de connexion et authentifiez l'utilisateur

                if (ModelState.IsValid)
                {
                    // Vérifiez les informations de connexion et authentifiez l'utilisateur

                    // Exemple de vérification simple
                    if (email == "admin@example.com" && password == "admin123")
                    {
                        // Authentification réussie, redirigez vers l'espace admin
                        return RedirectToAction("List", "Admin");
                    }
                    else
                    {
                        // Authentification échouée, ajoutez un message d'erreur
                        ModelState.AddModelError("", "Les informations de connexion sont incorrectes.");
                       
                }
                }
            return View("Index", "Admin");


        }

       
        public IActionResult LogOut()
        {
            return View("Index","Home");
        }




    }
}