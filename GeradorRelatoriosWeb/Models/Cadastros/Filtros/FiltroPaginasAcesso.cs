using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Cadastros.Filtros
{
    public class FiltroPaginasAcesso
    {
        public Guid Id { get; set; }
        [Display(Name = "Nome do Menu")]
        public string NomeMenu { get; set; }
        [Required]
        public string Controller { get; set; }
        [Required]
        public string View { get; set; }
        [Required]
        public bool Desativado { get; set; }
        public List<PaginasAcesso> PaginasAcessoLista { get; set; }

        public FiltroPaginasAcesso()
        {
            PaginasAcessoLista = new List<PaginasAcesso>();
        }
    }
}
