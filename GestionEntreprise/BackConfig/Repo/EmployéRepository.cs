using GestionEntreprise.BackConfig.Context;
using GestionEntreprise.Models;

namespace GestionEntreprise.BackConfig.Repo
{
    public class EmployéRepository : Repository<Employé>, IEmployéRepository
    {
        public EmployéRepository(Entreprise
            
            context) : base(context)
        {
        }

        public Employé Update(int id, Employé employé)
        {
            Employé changedEmploye = GetById(id);
            changedEmploye.PrenomEmploye = employé.PrenomEmploye;
            changedEmploye.NomEmploye = employé.NomEmploye;
            changedEmploye.NomSecteur=employé.NomSecteur;
            changedEmploye.Salaire = employé.Salaire;
            changedEmploye.DateEmbauche = employé.DateEmbauche;
            changedEmploye.DateNaissance = employé.DateNaissance;
            _context.Employes.Update(changedEmploye);
            return employé;
        }
    }
}
