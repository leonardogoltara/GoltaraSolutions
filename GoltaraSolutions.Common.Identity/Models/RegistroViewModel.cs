using System.ComponentModel.DataAnnotations;

namespace GoltaraSolutions.Common.Identity.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        //[Required]
        //[Display(Name = "Telefone")]
        //public string Telefone { get; set; }

        //[Required]
        //[Display(Name = "Celular")]
        //public string Celular { get; set; }

        //        [DisplayFormat(ApplyFormatInEditMode = true,
        //    DataFormatString = "{0:dd/MM/yyyy}")]
        //[DataType(DataType.Text, ErrorMessage = "O campo {0} tem que ser uma data.")]
        //[Required(ErrorMessage = "A {0} é obrigatória.")]
        //[Display(Name = "Data de Nasc.")]
        //public DateTime DataNascimento { get; set; }

        //[Required]
        //[Display(Name = "CPF")]
        //public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "{0} inválido.")]
        [Display(Name = "Email de acesso")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("Senha", ErrorMessage = "A senha e sua confirmação são divergentes.")]
        public string ConfirmarSenha { get; set; }
    }
}
