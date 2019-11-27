using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Ocorrencia
    {
        [Display(Name = "ID Ocorrencia")]
        public int IdOcorrencia { get; set; }

        [Display(Name = "ID Morador")]
        public int IdMoradorFkOcorrencia { get; set; }

        [Display(Name = "Tipo de Ocorrencia")]
        public string Tipo { get; set; }

        [Display(Name = "Data da Ocorrencia")]
        public string DataOcorrencia { get; set; }

        [Display(Name = "ID Sindico")]
        public int IdSindicoFkOcorrencia { get; set; }

        [Display(Name = "Ocorrido")]
        public string Descricao { get; set; }

        [Display(Name = "Morador")]
        public string Nome { get; set; }

        [Display(Name = "Sindico")]
        public string NomeSindico { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

    }
}
