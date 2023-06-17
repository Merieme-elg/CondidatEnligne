using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Condidature.Models
{
    [Table("Admins")]
    public class Admin
    {
        [Key]
        [Display(Name = "IdAdmin")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAdmin{ get; set; }

        [Required]
        [Display(Name = "NomAdmin")]
        [Column(TypeName = "varchar(30)")]
        public string NomAdmin { get; set; } = string.Empty;

        [Required]
        [Display(Name = "PrenomAdmin")]
        [Column(TypeName = "varchar(30)")]
        public string PrenomAdmin { get; set; } = string.Empty;

        [Required]
        [Display(Name = "EmailAdmin")]
        [Column(TypeName = "varchar(30)")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        [Display(Name = "Password")]
        [Column(TypeName = "varchar(30)")]
        public string Password { get; set; } = string.Empty;

    }
}
