using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoValoresRecolhidos
    {
        [Display(Name = "Identificação do Repasse")]
        public string IdentificacaoRepasse { get; set; }
        [Display(Name = "Data do Repasse")]
        public string DataRepasse { get; set; }
        public string FUNSET { get; set; }
        public string DETRAN { get; set; }
        public string DENATRAN { get; set; }
        [Display(Name = "Orgão Autuador")]
        public string OrgaoAutuador { get; set; }
    }
}
