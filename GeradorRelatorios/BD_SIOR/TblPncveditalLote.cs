using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncveditalLote
    {
        public TblPncveditalLote()
        {
            TblInfracaoPreAutuacaoConferenciaSimplesPncv = new HashSet<TblInfracaoPreAutuacaoConferenciaSimplesPncv>();
            TblPncveditalLoteAbrangencia = new HashSet<TblPncveditalLoteAbrangencia>();
            TblPncvequipamento = new HashSet<TblPncvequipamento>();
            TblPncvestudoTecnicoInstalacao = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvnotaInstalacao = new HashSet<TblPncvnotaInstalacao>();
            TblPncvsolicitacaoTransferenciaContrato = new HashSet<TblPncvsolicitacaoTransferenciaContrato>();
            TblSistemaUsuarioPncveditalLote = new HashSet<TblSistemaUsuarioPncveditalLote>();
        }

        public int CodigoPncveditalLote { get; set; }
        public int CodigoPncvoperadora { get; set; }
        public string NumeroContrato { get; set; }
        public byte NumeroLote { get; set; }
        public string NumeroProcessoContrato { get; set; }
        public int CodigoPncvedital { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime DataTerminoVigencia { get; set; }
        public bool IndicadorEstudoInstalacaoAutorizacaoElaboracao { get; set; }
        public bool IndicadorEquipamentoAutorizacaoInstalacao { get; set; }
        public bool IndicadorEquipamentoGerenciamentoFaixa { get; set; }

        public virtual TblPncvedital CodigoPncveditalNavigation { get; set; }
        public virtual TblPncvoperadora CodigoPncvoperadoraNavigation { get; set; }
        public virtual TblPncvparametrosEditalLote TblPncvparametrosEditalLote { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaSimplesPncv> TblInfracaoPreAutuacaoConferenciaSimplesPncv { get; set; }
        public virtual ICollection<TblPncveditalLoteAbrangencia> TblPncveditalLoteAbrangencia { get; set; }
        public virtual ICollection<TblPncvequipamento> TblPncvequipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacao { get; set; }
        public virtual ICollection<TblPncvnotaInstalacao> TblPncvnotaInstalacao { get; set; }
        public virtual ICollection<TblPncvsolicitacaoTransferenciaContrato> TblPncvsolicitacaoTransferenciaContrato { get; set; }
        public virtual ICollection<TblSistemaUsuarioPncveditalLote> TblSistemaUsuarioPncveditalLote { get; set; }
    }
}
