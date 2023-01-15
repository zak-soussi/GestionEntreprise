using GestionEntreprise.Models;

namespace GestionEntreprise.BackConfig.Repo
{
    public interface IEmployéRepository : IRepository<Employé>
    {
        public Employé Update(int id, Employé employé);

    }
}
