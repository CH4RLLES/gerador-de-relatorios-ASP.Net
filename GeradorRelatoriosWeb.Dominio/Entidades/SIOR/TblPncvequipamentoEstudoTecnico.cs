using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoEstudoTecnico
    {
        public TblPncvequipamentoEstudoTecnico()
        {
            TblPncvequipamentoEstudoTecnicoArquivo = new HashSet<TblPncvequipamentoEstudoTecnicoArquivo>();
            TblPncvequipamentoEstudoTecnicoFaixa = new HashSet<TblPncvequipamentoEstudoTecnicoFaixa>();
        }

        public int CodigoPncvequipamentoEstudoTecnico { get; set; }
        public int CodigoPncvequipamento { get; set; }
        public DateTime? ValidadeDataInicio { get; set; }
        public int? CodigoPncvestudoTecnicoInstalacao { get; set; }
        public int? CodigoPncvequipamentoIndicadorComunicacao { get; set; }
        public int? CodigoPncvestudoTecnicoTipo { get; set; }
        public int? CodigoPncvestudoTecnicoMonitoramento { get; set; }
        public short? CodigoPncvmodeloEquipamento { get; set; }
        public string CodigoIdentificacaoDnit { get; set; }
        public int CodigoBaseUf { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int CodigoRenavammunicipio { get; set; }
        public decimal NumeroKm { get; set; }
        public string CodigoSnv { get; set; }
        public DateTime DataVersaoSnv { get; set; }
        public DateTime? ValidadeDataTermino { get; set; }
        public bool IndicadorAtivo { get; set; }

        public virtual TblPncvequipamentoIndicadorComunicacao CodigoPncvequipamentoIndicadorComunicacaoNavigation { get; set; }
        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
        public virtual ICollection<TblPncvequipamentoEstudoTecnicoArquivo> TblPncvequipamentoEstudoTecnicoArquivo { get; set; }
        public virtual ICollection<TblPncvequipamentoEstudoTecnicoFaixa> TblPncvequipamentoEstudoTecnicoFaixa { get; set; }
    }
}
