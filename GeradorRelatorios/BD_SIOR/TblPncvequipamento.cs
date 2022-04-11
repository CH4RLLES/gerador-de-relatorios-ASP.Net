using GeoAPI.Geometries;
using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;

namespace GeradorRelatorios
{
    public partial class TblPncvequipamento
    {
        public TblPncvequipamento()
        {
            TblInfracaoNotificacaoRestricaoPncvequipamento = new HashSet<TblInfracaoNotificacaoRestricaoPncvequipamento>();
            TblPncvautorizacaoInstalacaoEquipamento = new HashSet<TblPncvautorizacaoInstalacaoEquipamento>();
            TblPncvautorizacaoInstalacaoEquipamentoRemanejamento = new HashSet<TblPncvautorizacaoInstalacaoEquipamentoRemanejamento>();
            TblPncvautorizacaoInstalacaoEquipamentoSubstituicao = new HashSet<TblPncvautorizacaoInstalacaoEquipamentoSubstituicao>();
            TblPncvequipamentoEstudoTecnico = new HashSet<TblPncvequipamentoEstudoTecnico>();
            TblPncvequipamentoEvento = new HashSet<TblPncvequipamentoEvento>();
            TblPncvequipamentoFaixa = new HashSet<TblPncvequipamentoFaixa>();
            TblPncvestudoTecnicoInstalacaoEquipamento = new HashSet<TblPncvestudoTecnicoInstalacaoEquipamento>();
            TblPncvnotaInstalacaoEquipamento = new HashSet<TblPncvnotaInstalacaoEquipamento>();
            TblPncvsolicitacaoCancelamentoEquipamento = new HashSet<TblPncvsolicitacaoCancelamentoEquipamento>();
            TblPncvsolicitacaoTransferenciaContratoEquipamento = new HashSet<TblPncvsolicitacaoTransferenciaContratoEquipamento>();
        }

        public int CodigoPncvequipamento { get; set; }
        public int CodigoBaseRodovia { get; set; }
        public int CodigoBaseUf { get; set; }
        public short? CodigoRenavammunicipio { get; set; }
        public short CodigoPncvmodeloEquipamento { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public string CodigoEquipamentoDnit { get; set; }
        public string CodigoSnv { get; set; }
        public byte? NumeroItemNotaInstalacao { get; set; }
        public decimal NumeroKm { get; set; }
        public DateTime DataVersaoSnv { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public int CodigoPncvequipamentoTipo { get; set; }
        public int? CodigoPncvestudoTecnicoInstalacao { get; set; }
        public int? CodigoPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public DateTime? DataInicioOperacao { get; set; }
        public IPoint Coordenadas { get; set; }

        public virtual TblBaseRodovia CodigoBaseRodoviaNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual TblPncveditalLote CodigoPncveditalLoteNavigation { get; set; }
        public virtual TblPncvequipamentoTipo CodigoPncvequipamentoTipoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacaoEquipamento CodigoPncvestudoTecnicoInstalacaoEquipamentoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
        public virtual TblPncvmodeloEquipamento CodigoPncvmodeloEquipamentoNavigation { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoRestricaoPncvequipamento> TblInfracaoNotificacaoRestricaoPncvequipamento { get; set; }
        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamento> TblPncvautorizacaoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamentoRemanejamento> TblPncvautorizacaoInstalacaoEquipamentoRemanejamento { get; set; }
        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamentoSubstituicao> TblPncvautorizacaoInstalacaoEquipamentoSubstituicao { get; set; }
        public virtual ICollection<TblPncvequipamentoEstudoTecnico> TblPncvequipamentoEstudoTecnico { get; set; }
        public virtual ICollection<TblPncvequipamentoEvento> TblPncvequipamentoEvento { get; set; }
        public virtual ICollection<TblPncvequipamentoFaixa> TblPncvequipamentoFaixa { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoEquipamento> TblPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvnotaInstalacaoEquipamento> TblPncvnotaInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvsolicitacaoCancelamentoEquipamento> TblPncvsolicitacaoCancelamentoEquipamento { get; set; }
        public virtual ICollection<TblPncvsolicitacaoTransferenciaContratoEquipamento> TblPncvsolicitacaoTransferenciaContratoEquipamento { get; set; }
    }
}
