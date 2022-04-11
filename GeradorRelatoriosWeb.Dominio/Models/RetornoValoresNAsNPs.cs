using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoValoresNAsNPs
    {
        public List<RetornoListaNA> ListaNAs { get; set; }
        public List<RetornoListaNP> ListaNPs { get; set; }

        public RetornoValoresNAsNPs()
        {
            ListaNAs = new List<RetornoListaNA>();
            ListaNPs = new List<RetornoListaNP>();
        }
    }
}
