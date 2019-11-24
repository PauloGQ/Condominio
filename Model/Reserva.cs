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

        [Display(Name = "Data da Solicitação")]
        public DateTime DataSolicitacao { get; set; }

        [Display(Name = "Data da Solicitação")]
        public DateTime DataReserva { get; set; }

        [Display(Name = "Nome do Local")]
        public int NomeLocal { get; set; }

        [Display(Name = "Valor")]
        public int Valor { get; set; }
    }
}
