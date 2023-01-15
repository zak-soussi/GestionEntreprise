using System.ComponentModel.DataAnnotations;

namespace GestionEntreprise.Models
{
    public class Secteur
    {
        [Key]
        public int SecteurId { get; set; }
        public string SecteurName { get;set; }
        public int MaxEmploye { get; set; }


    }
}
