    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace Model
{

    public class Morador
    {
        [Display(Name = "ID Morador")]
        public int IdMorador { get; set; }

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

        [Display(Name = "ID Apartamento")]
        public int IdApartamentoFkMorador { get; set; }

        [Display(Name = "Apartamento")]
        public int Apt { get; set; }

        [Display(Name = "Bloco")]
        public string Bloco { get; set; }

        [Display(Name = "Vaga")]
        public string Vaga { get; set; }


    }


}
