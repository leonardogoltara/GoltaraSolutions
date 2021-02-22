using System.ComponentModel.DataAnnotations;

namespace GoltaraSolutions.Common.Identity.Models
{
    public class EsqueciMinhaSenhaViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress]
        [Display(Name = "Email de acesso")]
        public string Email { get; set; }
    }
}
