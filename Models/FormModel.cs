using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TPLOCAL1.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "Veuillez saisir votre nom")]
        public string nom { get; set; }
        [Required(ErrorMessage = "Veuillez saisir votre prénom")]
        public string prenom { get; set; }
        [Required] 
        public string sexe { get; set; }
        [Required(ErrorMessage = "Veuillez saisir votre adresse")]
        public string adresse { get; set; }
        [Required(ErrorMessage = "Veuillez saisir une code postale")] 
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Code postale non valide")]
        [StringLength(5, ErrorMessage = "Code postale non valide")]
        public string codePostale { get; set; }
        [Required(ErrorMessage = "Veuillez saisir une ville")]
        public string ville { get; set; }
        [Required(ErrorMessage = "Veuillez saisir votre adress mail")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]+$", ErrorMessage = "Adresse mail non valide")]
        public string courriel { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime dateDebut { get; set; }
        [Required]
        public string formation { get; set; }
        public string? formationCobol { get; set; }
        public string? formationCSharp { get; set; }
    }
}
