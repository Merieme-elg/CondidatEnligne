using Condidature.Models;
using Condidature.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;

namespace Condidature.Controllers
{
    public class CondidatController : Controller
    {
        private readonly ICondidate _ICondidate;
        private readonly IWebHostEnvironment _environement;
        public CondidatController(ICondidate ICondidate, IWebHostEnvironment environement)
        {
            _ICondidate = ICondidate;
            _environement = environement;

        }
        public IActionResult Index()
        {
            return View();
        }

        //Registration process
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

       

        [HttpPost]
        public IActionResult Register(Condidat condidat, IFormFile CV)
        {
            if (CV != null && CV.Length > 0)
            {
                // Récupérer le nom et le prénom du candidat depuis le modèle
                string nom = condidat.Nom;
                string prenom = condidat.Prenom;

                // Générer le chemin du répertoire basé sur le nom et le prénom du candidat
                string directoryPath = Path.Combine(_environement.WebRootPath + "/CV/", nom + "_" + prenom);

                // Créer le répertoire s'il n'existe pas déjà
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Générer le nom de fichier unique pour le CV (pour éviter les conflits)
                string fileName = nom + "_" + prenom + Path.GetExtension(CV.FileName); 

                // Générer le chemin complet du fichier
                string filePath = Path.Combine(directoryPath, fileName);

                // Enregistrer le fichier CV sur le disque
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    CV.CopyTo(stream);
                }

                // Ajouter le chemin du fichier CV dans le modèle de candidature
                condidat.CV = filePath;

                // Enregistrer le modèle de candidature dans la base de données ou effectuer d'autres opérations nécessaires
                _ICondidate.Register(condidat);


                // Afficher un message de confirmation

                TempData["ConfirmationMessage"] = "Inscription réussie. Vous pouvez maintenant vous connecter.";

                // Rediriger vers une page de confirmation 
                return RedirectToAction("Index");

            }

            // Si aucun fichier CV n'est fourni Afficher à nouveau le formulaire 
            return View("Register", condidat); 
        }

    

    

        }

    }
