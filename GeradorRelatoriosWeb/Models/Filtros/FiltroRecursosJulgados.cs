using GeradorRelatoriosWeb.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorRelatoriosWeb.Models.Filtros
{
    public class FiltroRecursosJulgados
    {
        public int Ano { get; set; }

        public List<RetornoRecursosJulgados> RetornoRecursosJulgados { get; set; }

        public FiltroRecursosJulgados()
        {
            RetornoRecursosJulgados = new List<RetornoRecursosJulgados>();
        }
    }
}
