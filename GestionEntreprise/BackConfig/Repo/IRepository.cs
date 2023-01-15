using System.Linq.Expressions;

namespace GestionEntreprise.BackConfig.Repo
{
    public interface  IRepository<Entity> where Entity : class
    {
        Entity? GetById(int id);
        IEnumerable<Entity> GetAll();
        bool Add(Entity entity);
        bool Remove(Entity entity);

    }
}
