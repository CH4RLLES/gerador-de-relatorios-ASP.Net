using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroAlterarSenha
    {
        public Guid Id { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Senha Atual")]
        public string SenhaAtual { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha")]
        public string NovaSenha { get; set; }
        [DataType(DataType.Password)]
        [Compare("NovaSenha")]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmarSenha { get; set; }
    }
}
