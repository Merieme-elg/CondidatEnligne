using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Condidature.Models
{
    [Table("Condidats")]
    public class Condidat
    {

        [Key]
        [Display(Name = "IdCondidat")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdCondidat { get; set; }

        [Required]
        [Display(Name = "Nom")]
        [Column(TypeName = "varchar(30)")]
        public string Nom { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Prenom")]
        [Column(TypeName = "varchar(30)")]
        public string Prenom { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Email")]
        [Column(TypeName = "varchar(30)")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Téléphone")]
        [Column(TypeName = "int")]
        public int Téléphone { get; set; }

        [Required]
        [Display(Name = "Niveau d’étude")]
        [Column(TypeName = "varchar(10)")]
        public String Niveau { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Années d'expérience")]
        [Column(TypeName = "int")]
        public int expérience { get; set; }

        [Required]
        [Display(Name = "Dernier employeur")]
        [Column(TypeName = "varchar(50)")]
        public String employeur { get; set; } = String.Empty;

        [Display(Name = "CV")]
        [Column(TypeName = "varbinary(MAX)")]
        public String CV { get; set; } = String.Empty;

    }
}

