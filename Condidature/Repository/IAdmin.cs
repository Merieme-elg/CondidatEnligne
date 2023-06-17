using Condidature.Models;
using Microsoft.AspNetCore.Mvc;

namespace Condidature.Repository
{
    public interface IAdmin
    {
        public List<Condidat> GetCondidats();
        public void Delete(int Id);

        public void Login(string email, string password);
        public void Logout();
        public List<Condidat> Recherche(string nom, string prenom, string email);

    }
}
