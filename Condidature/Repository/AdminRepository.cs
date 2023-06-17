using Condidature.DBContext;
using Condidature.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Condidature.Repository
{
    public class AdminRepository : IAdmin
    {
        private readonly MyDBContext _context;
        public AdminRepository(MyDBContext context)
        {
            _context = context;
        }
        public List<Condidat> GetCondidats()
        {
           
                var Result = _context.Condidats.ToList();

                return Result;
           

        }

        public void Delete(int Id)
        {
            var result = _context.Condidats.Find(Id);
            if (result != null)
            {
                _context.Condidats.Remove(result);
                _context.SaveChanges();
            }

        }

    //fonction de recherche 
        public List<Condidat> Recherche(string nom, string prenom, string email)
        {

            var candidatures = _context.Condidats
            .Where(c =>
                (string.IsNullOrEmpty(nom) || c.Nom.Contains(nom)) &&
                (string.IsNullOrEmpty(prenom) || c.Prenom.Contains(prenom)) &&
                (string.IsNullOrEmpty(email) || c.Email.Contains(email))
            )
            .ToList();
            return candidatures;

        }

        public void Login(string email, string password)
        {

        }

        public void Logout()
        {

        }
    }
}
