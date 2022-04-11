using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Models
{
    public class RetornoProcessosInstruir
    {
        public List<RetornoListaDA> ListaDAs { get; set; }
        public List<RetornoListaFICI> ListaFICIs { get; set; }
        public List<RetornoListaFIRI> ListaFIRIs { get; set; }
        public List<RetornoListaSA> ListaSAs { get; set; }
        public List<RetornoListaRecurso> ListaRecursos { get; set; }

        public RetornoProcessosInstruir()
        {
            ListaDAs = new List<RetornoListaDA>();
            ListaFICIs = new List<RetornoListaFICI>();
            ListaFIRIs = new List<RetornoListaFIRI>();
            ListaSAs = new List<RetornoListaSA>();
            ListaRecursos = new List<RetornoListaRecurso>();
        }

    }
}
