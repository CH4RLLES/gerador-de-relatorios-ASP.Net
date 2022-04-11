using GeradorRelatoriosWeb.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Entidades.Sistema
{
    public class Usuario : EntidadeBase
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Token { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Display(Name = "Perfil")]
        public Guid IdPerfil { get; set; }
        [ForeignKey("IdPerfil")]
        public PerfilAcesso Perfil { get; set; }
        [Required]
        public EnumStatusAcesso Status { get; set; }
    }
}
