using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvsolicitacaoTransferenciaContrato
    {
        public TblPncvsolicitacaoTransferenciaContrato()
        {
            TblPncvsolicitacaoTransferenciaContratoArquivo = new HashSet<TblPncvsolicitacaoTransferenciaContratoArquivo>();
            TblPncvsolicitacaoTransferenciaContratoEquipamento = new HashSet<TblPncvsolicitacaoTransferenciaContratoEquipamento>();
            TblPncvsolicitacaoTransferenciaContratoEvento = new HashSet<TblPncvsolicitacaoTransferenciaContratoEvento>();
        }

        public int CodigoPncvsolicitacaoTransferenciaContrato { get; set; }
        public int CodigoPncvsolicitacaoTransferenciaContratoSituacao { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public DateTime DataProtocolo { get; set; }
        public string Solicitante { get; set; }
        public int QuantidadeEquipamento { get; set; }
        public string Observacoes { get; set; }

        public virtual TblPncveditalLote CodigoPncveditalLoteNavigation { get; set; }
        public virtual TblPncvsolicitacaoTransferenciaContratoSituacao CodigoPncvsolicitacaoTransferenciaContratoSituacaoNavigation { get; set; }
        public virtual ICollection<TblPncvsolicitacaoTransferenciaContratoArquivo> TblPncvsolicitacaoTransferenciaContratoArquivo { get; set; }
        public virtual ICollection<TblPncvsolicitacaoTransferenciaContratoEquipamento> TblPncvsolicitacaoTransferenciaContratoEquipamento { get; set; }
        public virtual ICollection<TblPncvsolicitacaoTransferenciaContratoEvento> TblPncvsolicitacaoTransferenciaContratoEvento { get; set; }
    }
}
