using System.ComponentModel.DataAnnotations;


namespace GestionEntreprise.Models
{
    public class Employé
    {
        [Key]
        public int? EmployeId { get; set; }

        public string NomEmploye { get; set; }

        public string PrenomEmploye { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateEmbauche { get; set; }

        public decimal? Salaire { get; set; }

        public string NomSecteur { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateNaissance { get; set; }
    }
}
