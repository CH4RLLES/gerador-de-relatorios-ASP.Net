using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSegurancaAcidenteTransitoFonteDados
    {
        public int CodigoSegurancaAcidenteTransitoFonteDados { get; set; }
        public string Nome { get; set; }
        public int AnoReferencia { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
