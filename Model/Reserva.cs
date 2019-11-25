using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reserva
    {
        [Display(Name = "ID Reserva")]
        public int IdReserva { get; set; }

        [Display(Name = "ID Morador")]
        public int IdMoradorFkReserva { get; set; }

        [Display(Name = "ID Local")]
        public int IdLocalFkReserva { get; set; }

        [Display(Name = "Data da Solicitacao")]
        public DateTime DataSolicitacao { get; set; }

        [Display(Name = "Data da Reserva")]
        public DateTime DataReserva { get; set; }

        [Display(Name = "Nome do Local")]
        public string NomeLocal { get; set; }

        [Display(Name = "Valor")]
        public string Valor { get; set; }

        [Display(Name = "Morador")]
        public string Nome { get; set; }


    }
}
