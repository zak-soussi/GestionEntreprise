using GestionEntreprise.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionEntreprise.BackConfig.Context
{
    public class EntrepriseDbContext : DbContext
    {
        public DbSet<Secteur> Secteurs { get; set; }
        public DbSet<Employé> Employes { get; set; }

        private static EntrepriseDbContext? _instance;

        public static EntrepriseDbContext Instance
        {
            get
            {
                if(_instance==null)
                {
                    _instance = Instantiate_EntrepriseDbContext();
                }
                return _instance;
            }
        }

        private EntrepriseDbContext(DbContextOptions opt): base(opt)
        {

        }

        private static EntrepriseDbContext Instantiate_EntrepriseDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EntrepriseDbContext>();
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Lenovo\Desktop\sqlite-tools-win32-x86-3400000\gestionnaire.db");
            _instance=new EntrepriseDbContext(optionsBuilder.Options);
            return _instance;
        }

    }
}
