using GestionEntreprise.BackConfig.Context;
using GestionEntreprise.BackConfig.Repo;

namespace GestionEntreprise.BackConfig.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private EntrepriseDbContext context;
        public IEmployéRepository employe { get; private set; }

        public SecteurRepository secteur { get; private set; }

        public UnitofWork(EntrepriseDbContext context)
        {
            this.context = context;
            employe = new EmployéRepository(context);
            secteur = new SecteurRepository(context);
            
        }


        public bool Complete()
        {
            try
            {
                int success = context.SaveChanges();
                if(success>0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
