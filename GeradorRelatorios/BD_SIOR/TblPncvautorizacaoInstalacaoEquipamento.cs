using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvautorizacaoInstalacaoEquipamento
    {
        public TblPncvautorizacaoInstalacaoEquipamento()
        {
            TblPncvautorizacaoInstalacaoEquipamentoEvento = new HashSet<TblPncvautorizacaoInstalacaoEquipamentoEvento>();
            TblPncvautorizacaoInstalacaoEquipamentoRemanejamento = new HashSet<TblPncvautorizacaoInstalacaoEquipamentoRemanejamento>();
            TblPncvautorizacaoInstalacaoEquipamentoSubstituicao = new HashSet<TblPncvautorizacaoInstalacaoEquipamentoSubstituicao>();
            TblPncvestudoTecnicoInstalacaoEquipamento = new HashSet<TblPncvestudoTecnicoInstalacaoEquipamento>();
        }

        public int CodigoPncvautorizacaoInstalacaoEquipamento { get; set; }
        public int CodigoPncvautorizacaoInstalacaoEquipamentoSituacao { get; set; }
        public int CodigoPncvestudoTecnicoInstalacao { get; set; }
        public int CodigoPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public int? CodigoPncvequipamento { get; set; }
        public int CodigoPncvequipamentoIndicadorInstalacao { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime? DataAnalise { get; set; }
        public bool IndicadorRemanejamento { get; set; }
        public bool? IndicadorSubstituicao { get; set; }
        public string NomeUsuarioSolicitacao { get; set; }
        public string NomeUsuarioAnalise { get; set; }
        public DateTime? DataSolicitacaoRevisao { get; set; }
        public DateTime? DataRevisao { get; set; }
        public string NomeUsuarioSolicitacaoRevisao { get; set; }
        public string NomeUsuarioRevisao { get; set; }
        public string RevisaoMotivo { get; set; }
        public string RevisaoObservacao { get; set; }

        public virtual TblPncvautorizacaoInstalacaoEquipamentoSituacao CodigoPncvautorizacaoInstalacaoEquipamentoSituacaoNavigation { get; set; }
        public virtual TblPncvequipamentoIndicadorInstalacao CodigoPncvequipamentoIndicadorInstalacaoNavigation { get; set; }
        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacaoEquipamento CodigoPncvestudoTecnicoInstalacaoEquipamentoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamentoEvento> TblPncvautorizacaoInstalacaoEquipamentoEvento { get; set; }
        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamentoRemanejamento> TblPncvautorizacaoInstalacaoEquipamentoRemanejamento { get; set; }
        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamentoSubstituicao> TblPncvautorizacaoInstalacaoEquipamentoSubstituicao { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
    }
}
