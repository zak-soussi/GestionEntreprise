using GestionEntreprise.BackConfig.Repo;

namespace GestionEntreprise.BackConfig.UnitofWork
{
    public interface IUnitofWork
    {
        IEmployéRepository employe { get; }
        SecteurRepository secteur { get; }

        bool Complete();
    }
}
