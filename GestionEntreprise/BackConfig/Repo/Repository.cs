using GestionEntreprise.BackConfig.Context;

namespace GestionEntreprise.BackConfig.Repo
{
    public class Repository<Entity> : IRepository<Entity> where Entity : class
    {
        protected EntrepriseDbContext _context;
        public Repository(EntrepriseDbContext context)
        {
            _context = context;
        }
        public bool Add(Entity entity)
        {

            try
            {
                _context.Set<Entity>().Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public IEnumerable<Entity> GetAll()
        {
            return _context.Set<Entity>().ToList();
        }

        public Entity? GetById(int id)
        {
            return _context.Set<Entity>().Find(id);
        }

        public bool Remove(Entity entity)
        {
            try
            {
                _context.Set<Entity>().Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
