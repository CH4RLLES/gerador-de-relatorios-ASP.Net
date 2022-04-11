using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Entidades.Sistema
{
    public class PaginasAcesso : EntidadeBase
    {
        
        public string NomeMenu { get; set; }
        [Required]
        public string Controller { get; set; }
        [Required]
        public string View { get; set; }
        [Required]
        public bool Desativado { get; set; }
    }
}
