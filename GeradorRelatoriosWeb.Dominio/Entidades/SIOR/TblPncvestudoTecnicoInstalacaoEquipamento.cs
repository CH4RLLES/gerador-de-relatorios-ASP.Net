using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoInstalacaoEquipamento
    {
        public TblPncvestudoTecnicoInstalacaoEquipamento()
        {
            TblPncvautorizacaoInstalacaoEquipamento = new HashSet<TblPncvautorizacaoInstalacaoEquipamento>();
            TblPncvequipamento = new HashSet<TblPncvequipamento>();
            TblPncvestudoTecnicoInstalacaoFaixa = new HashSet<TblPncvestudoTecnicoInstalacaoFaixa>();
        }

        public int CodigoPncvestudoTecnicoInstalacaoEquipamento { get; set; }
        public int CodigoPncvestudoTecnicoInstalacao { get; set; }
        public short CodigoPncvmodeloEquipamento { get; set; }
        public int? CodigoPncvequipamentoIndicadorComunicacao { get; set; }
        public int? CodigoPncvequipamentoIndicadorTecnologia { get; set; }
        public int? CodigoPncvequipamentoIndicadorInstalacao { get; set; }
        public int? CodigoPncvequipamento { get; set; }
        public string Descricao { get; set; }
        public int? CodigoPncvautorizacaoInstalacaoEquipamento { get; set; }

        public virtual TblPncvautorizacaoInstalacaoEquipamento CodigoPncvautorizacaoInstalacaoEquipamentoNavigation { get; set; }
        public virtual TblPncvequipamentoIndicadorComunicacao CodigoPncvequipamentoIndicadorComunicacaoNavigation { get; set; }
        public virtual TblPncvequipamentoIndicadorInstalacao CodigoPncvequipamentoIndicadorInstalacaoNavigation { get; set; }
        public virtual TblPncvequipamentoIndicadorTecnologia CodigoPncvequipamentoIndicadorTecnologiaNavigation { get; set; }
        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
        public virtual TblPncvmodeloEquipamento CodigoPncvmodeloEquipamentoNavigation { get; set; }
        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamento> TblPncvautorizacaoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvequipamento> TblPncvequipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacaoFaixa> TblPncvestudoTecnicoInstalacaoFaixa { get; set; }
    }
}
