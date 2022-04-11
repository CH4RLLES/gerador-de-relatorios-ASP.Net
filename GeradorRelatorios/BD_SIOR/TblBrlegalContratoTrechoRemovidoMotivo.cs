using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBrlegalContratoTrechoRemovidoMotivo
    {
        public TblBrlegalContratoTrechoRemovidoMotivo()
        {
            TblBrlegalContratoTrechoRemovido = new HashSet<TblBrlegalContratoTrechoRemovido>();
        }

        public int CodigoBrlegalContratoTrechoRemovidoMotivo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblBrlegalContratoTrechoRemovido> TblBrlegalContratoTrechoRemovido { get; set; }
    }
}
