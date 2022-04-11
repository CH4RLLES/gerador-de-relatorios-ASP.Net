using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using GeradorRelatoriosWeb.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Cadastros.Filtros
{
    public class FiltroUsuario
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Token { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Display(Name = "Perfil")]
        public Guid IdPerfil { get; set; }
        [ForeignKey("IdPerfil")]
        public PerfilAcesso Perfil { get; set; }
        public EnumStatusAcesso Status { get; set; }


        public List<Usuario> UsuarioLista { get; set; }

        public FiltroUsuario()
        {
            UsuarioLista = new List<Usuario>();
        }
    }
}
