using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoFaixaVerificacao
    {
        public TblPncvequipamentoFaixaVerificacao()
        {
            TblPncvequipamentoFaixaVerificacaoEvento = new HashSet<TblPncvequipamentoFaixaVerificacaoEvento>();
            TblPncvequipamentoFaixaVerificacaoPlaca = new HashSet<TblPncvequipamentoFaixaVerificacaoPlaca>();
        }

        public int CodigoPncvequipamentoFaixaVerificacao { get; set; }
        public int CodigoPncvequipamentoFaixa { get; set; }
        public int CodigoPncvequipamentoFaixaVerificacaoSituacao { get; set; }
        public string NumeroVerificacaoInmetro { get; set; }
        public DateTime DataVerificacao { get; set; }
        public DateTime DataValidadeVerificacao { get; set; }
        public DateTime DataFotosSinalizacao { get; set; }
        public string ObservacaoAnalise { get; set; }
        public string ArquivoCertificadoNome { get; set; }
        public string ArquivoLaudoNome { get; set; }
        public string FotoNumeroVerificacaoNome { get; set; }
        public string FotoVeiculoInmetroNome { get; set; }
        public string FotoPanoramicaEquipamentoNome { get; set; }
        public string FotoPanoramicaEquipamentoOpcionalNome { get; set; }
        public string FotoTesteInfracaoNome { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime? DataDeferimento { get; set; }
        public string ArquivoCertificadoNomeFisico { get; set; }
        public string ArquivoLaudoNomeFisico { get; set; }
        public string FotoNumeroVerificacaoNomeFisico { get; set; }
        public string FotoVeiculoInmetroNomeFisico { get; set; }
        public string FotoPanoramicaEquipamentoNomeFisico { get; set; }
        public string FotoPanoramicaEquipamentoOpcionalNomeFisico { get; set; }
        public string FotoTesteInfracaoNomeFisico { get; set; }
        public int? ArquivoCertificadoTamanho { get; set; }
        public int? ArquivoLaudoTamanho { get; set; }
        public int FotoNumeroVerificacaoTamanho { get; set; }
        public int FotoVeiculoInmetroTamanho { get; set; }
        public int? FotoPanoramicaEquipamentoTamanho { get; set; }
        public int? FotoPanoramicaEquipamentoOpcionalTamanho { get; set; }
        public int? FotoTesteInfracaoTamanho { get; set; }

        public virtual TblPncvequipamentoFaixa CodigoPncvequipamentoFaixaNavigation { get; set; }
        public virtual TblPncvequipamentoFaixaVerificacaoSituacao CodigoPncvequipamentoFaixaVerificacaoSituacaoNavigation { get; set; }
        public virtual ICollection<TblPncvequipamentoFaixaVerificacaoEvento> TblPncvequipamentoFaixaVerificacaoEvento { get; set; }
        public virtual ICollection<TblPncvequipamentoFaixaVerificacaoPlaca> TblPncvequipamentoFaixaVerificacaoPlaca { get; set; }
    }
}
