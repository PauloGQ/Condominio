using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sindico
    {
        [Display(Name = "ID Sindico")]
        public int IdSindico{ get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} deve conter entre {2} e {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "O campo {0} é inválido")]
        public string Email { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cpf { get; set; }

        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

    }

}
