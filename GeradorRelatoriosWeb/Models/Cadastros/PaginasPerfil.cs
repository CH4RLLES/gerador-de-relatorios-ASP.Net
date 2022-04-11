using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Cadastros
{
    public class PaginasPerfil
    {
        [Display(Name = "Perfil")]
        public Guid IdPerfil { get; set; }
        [Display(Name = "Páginas")]
        public PaginasAcesso[] IdsPaginas { get; set; }
    }
}
