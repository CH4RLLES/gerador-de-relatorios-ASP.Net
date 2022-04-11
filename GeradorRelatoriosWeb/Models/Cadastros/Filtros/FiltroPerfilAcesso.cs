using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Cadastros.Filtros
{
    public class FiltroPerfilAcesso
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public List<PerfilPaginas> Paginas { get; set; }

        public List<PerfilAcesso> PerfilAcessoLista { get; set; }

        public FiltroPerfilAcesso()
        {
            PerfilAcessoLista = new List<PerfilAcesso>();
        }
    }
}
