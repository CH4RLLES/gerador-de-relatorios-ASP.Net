using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.RENAVAM
{
    public partial class TblRenavamenquadramento
    {
        public int CodigoRenavamenquadramento { get; set; }
        public string CodigoRenavamenquadramentoTexto { get; set; }
        public int CodigoEnquadramentoInfracao { get; set; }
        public int Desdobramento { get; set; }
        public string Descricao { get; set; }
        public string AmparoLegal { get; set; }
        public int? Gravidade { get; set; }
        public int? FatorGravidade { get; set; }
    }
}
