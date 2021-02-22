using GoltaraSolutions.Common.Extensions;
using System.ComponentModel.DataAnnotations;

namespace GoltaraSolutions.Common.Identity.Models
{
    public class EditarViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        //[Required]
        //[Display(Name = "Telefone")]
        //public string Telefone { get; set; }

        //[Required]
        //[Display(Name = "Celular")]
        //public string Celular { get; set; }

        //[DisplayFormat(ApplyFormatInEditMode = true,
        //    DataFormatString = "{0:dd/MM/yyyy}")]
        //[DataType(DataType.Text, ErrorMessage = "O campo {0} tem que ser uma data.")]
        //[Required(ErrorMessage = "A {0} é obrigatória.")]
        //[Display(Name = "Data de Nasc.")]
        //public DateTime DataNascimento { get; set; }

        //[Required]
        //[Display(Name = "CPF")]
        //public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress]
        [Display(Name = "Email de acesso")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Range(1, 3, ErrorMessage = "Escolha um Grupo de Acesso.")]
        [Display(Name = "Grupo de Acesso")]
        public GrupoDeAcesso Grupo { get; set; }

        public bool Deletado { get; set; }

        public string Ativo
        {
            get
            {
                return (!Deletado).ToCustomString();
            }
        }
    }
}
