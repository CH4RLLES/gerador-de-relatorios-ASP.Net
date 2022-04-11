using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvequipamentoFaixaParalisacao
    {
        public TblPncvequipamentoFaixaParalisacao()
        {
            TblPncvequipamentoFaixaParalisacaoEvento = new HashSet<TblPncvequipamentoFaixaParalisacaoEvento>();
        }

        public int CodigoPncvequipamentoFaixaParalisacao { get; set; }
        public int CodigoPncvequipamentoFaixa { get; set; }
        public int CodigoPncvequipamentoFaixaParalisacaoMotivo { get; set; }
        public int CodigoPncvequipamentoFaixaParalisacaoSituacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataEncerramento { get; set; }
        public string ObservacaoAnaliseInicio { get; set; }
        public string ObservacaoAnaliseEncerramento { get; set; }
        public string ArquivoInicioNome { get; set; }
        public string ArquivoEncerramentoNome { get; set; }
        public byte[] RowVersion { get; set; }
        public string ArquivoInicioNomeFisico { get; set; }
        public string ArquivoEncerramentoNomeFisico { get; set; }
        public int ArquivoInicioTamanho { get; set; }
        public int? ArquivoEncerramentoTamanho { get; set; }

        public virtual TblPncvequipamentoFaixa CodigoPncvequipamentoFaixaNavigation { get; set; }
        public virtual TblPncvequipamentoFaixaParalisacaoMotivo CodigoPncvequipamentoFaixaParalisacaoMotivoNavigation { get; set; }
        public virtual TblPncvequipamentoFaixaParalisacaoSituacao CodigoPncvequipamentoFaixaParalisacaoSituacaoNavigation { get; set; }
        public virtual ICollection<TblPncvequipamentoFaixaParalisacaoEvento> TblPncvequipamentoFaixaParalisacaoEvento { get; set; }
    }
}
