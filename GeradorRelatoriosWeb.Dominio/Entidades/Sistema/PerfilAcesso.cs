using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Entidades.Sistema
{
    public class PerfilAcesso : EntidadeBase
    {
        [Display(Name = "Perfil de acesso")]
        public string Nome { get; set; }
        public List<PerfilPaginas> Paginas { get; set; }
    }


}
