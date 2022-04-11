using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSnvtrecho
    {
        public TblSnvtrecho()
        {
            TblBrlegalContratoTrecho = new HashSet<TblBrlegalContratoTrecho>();
            TblBrlegalContratoTrechoContratado = new HashSet<TblBrlegalContratoTrechoContratado>();
            TblBrlegalProjetoBasicoEntregaTrecho = new HashSet<TblBrlegalProjetoBasicoEntregaTrecho>();
            TblBrlegalProjetoBasicoEntregaTrechoNaoAceite = new HashSet<TblBrlegalProjetoBasicoEntregaTrechoNaoAceite>();
            TblBrlegalProjetoExecutivoEntregaTrecho = new HashSet<TblBrlegalProjetoExecutivoEntregaTrecho>();
            TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite = new HashSet<TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite>();
            TblSnvtrechoHistorico = new HashSet<TblSnvtrechoHistorico>();
        }

        public int CodigoSnvtrecho { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int CodigoBaseUf { get; set; }
        public string CodigoSnvtrechoDnit { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual ICollection<TblBrlegalContratoTrecho> TblBrlegalContratoTrecho { get; set; }
        public virtual ICollection<TblBrlegalContratoTrechoContratado> TblBrlegalContratoTrechoContratado { get; set; }
        public virtual ICollection<TblBrlegalProjetoBasicoEntregaTrecho> TblBrlegalProjetoBasicoEntregaTrecho { get; set; }
        public virtual ICollection<TblBrlegalProjetoBasicoEntregaTrechoNaoAceite> TblBrlegalProjetoBasicoEntregaTrechoNaoAceite { get; set; }
        public virtual ICollection<TblBrlegalProjetoExecutivoEntregaTrecho> TblBrlegalProjetoExecutivoEntregaTrecho { get; set; }
        public virtual ICollection<TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite> TblBrlegalProjetoExecutivoEntregaTrechoNaoAceite { get; set; }
        public virtual ICollection<TblSnvtrechoHistorico> TblSnvtrechoHistorico { get; set; }
    }
}
