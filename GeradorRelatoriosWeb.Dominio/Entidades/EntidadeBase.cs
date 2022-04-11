using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Entidades
{
    public class EntidadeBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
