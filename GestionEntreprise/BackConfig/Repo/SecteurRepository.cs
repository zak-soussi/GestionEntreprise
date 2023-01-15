using GestionEntreprise.BackConfig.Context;
using GestionEntreprise.Models;

namespace GestionEntreprise.BackConfig.Repo
{
    public class SecteurRepository : Repository<Secteur>, IRepository<Secteur>
    {
        public SecteurRepository(EntrepriseDbContext context) : base(context)
        {
        }

        public Secteur Update(int id, Secteur secteur)
        {
            Secteur changedSecteur = GetById(id);
            changedSecteur.SecteurName= secteur.SecteurName;
            changedSecteur.MaxEmploye = secteur.MaxEmploye;

            _context.Secteurs.Update(changedSecteur);
            return changedSecteur;
        }
    }
}
