using Condidature.DBContext;
using Condidature.Models;

namespace Condidature.Repository
{
    public class CondidateRepository : ICondidate
    {
        private readonly MyDBContext _context;
        public CondidateRepository(MyDBContext context)
        {
            _context = context;
        }
        public void Register(Condidat condidat)
        {
            try
            {
                // Enregistrer le modèle de candidature dans la base de données 
                _context.Condidats.Add(condidat);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }
        }


    }
}
