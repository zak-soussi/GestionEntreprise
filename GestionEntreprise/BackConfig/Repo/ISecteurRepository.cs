using GestionEntreprise.Models;

namespace GestionEntreprise.BackConfig.Repo
{
    public interface ISecteurRepository : IRepository<Secteur>
    {
        public Secteur Update(int id, Secteur secteur);
    }
}
