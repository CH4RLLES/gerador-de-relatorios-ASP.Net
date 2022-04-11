using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalContratoTrechoSuspensoMotivo
    {
        public TblBrlegalContratoTrechoSuspensoMotivo()
        {
            TblBrlegalContratoTrechoSuspenso = new HashSet<TblBrlegalContratoTrechoSuspenso>();
        }

        public int CodigoBrlegalContratoTrechoSuspensoMotivo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblBrlegalContratoTrechoSuspenso> TblBrlegalContratoTrechoSuspenso { get; set; }
    }
}
