using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvsolicitacaoCancelamento
    {
        public TblPncvsolicitacaoCancelamento()
        {
            TblPncvsolicitacaoCancelamentoArquivo = new HashSet<TblPncvsolicitacaoCancelamentoArquivo>();
            TblPncvsolicitacaoCancelamentoEquipamento = new HashSet<TblPncvsolicitacaoCancelamentoEquipamento>();
            TblPncvsolicitacaoCancelamentoEvento = new HashSet<TblPncvsolicitacaoCancelamentoEvento>();
        }

        public int CodigoPncvsolicitacaoCancelamento { get; set; }
        public int CodigoPncvsolicitacaoCancelamentoSituacao { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime? DataDeferimento { get; set; }
        public string Solicitante { get; set; }
        public string Observacoes { get; set; }
        public int QuantidadeEquipamento { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual TblPncvsolicitacaoCancelamentoSituacao CodigoPncvsolicitacaoCancelamentoSituacaoNavigation { get; set; }
        public virtual ICollection<TblPncvsolicitacaoCancelamentoArquivo> TblPncvsolicitacaoCancelamentoArquivo { get; set; }
        public virtual ICollection<TblPncvsolicitacaoCancelamentoEquipamento> TblPncvsolicitacaoCancelamentoEquipamento { get; set; }
        public virtual ICollection<TblPncvsolicitacaoCancelamentoEvento> TblPncvsolicitacaoCancelamentoEvento { get; set; }
    }
}
