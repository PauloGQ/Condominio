using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comunicado
    {
        [Display(Name = "ID Comunicado")]
        public int IdComunicado { get; set; }

        [Display(Name = "DataComunicado")]
        public DateTime DataComunicado { get; set; }

        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Display(Name = "ID Sindico")]
        public int IdSindicoFkComunicado { get; set; }
     


    }
}
