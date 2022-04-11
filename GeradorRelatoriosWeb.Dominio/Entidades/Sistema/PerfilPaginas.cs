using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Entidades.Sistema
{
    public class PerfilPaginas
    {
        [Required]
        public Guid IdPagina { get; set; }
        [ForeignKey("IdPagina")]
        public PaginasAcesso Pagina { get; set; }
        [Required]
        public Guid IdPerfil { get; set; }
        [ForeignKey("IdPerfil")]
        public PerfilAcesso Perfil { get; set; }

    }
}
