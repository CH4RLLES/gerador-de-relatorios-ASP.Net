using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvautorizacaoInstalacaoEquipamentoEvento
    {
        public int CodigoPncvautorizacaoInstalacaoEquipamentoEvento { get; set; }
        public int CodigoPncvautorizacaoInstalacaoEquipamento { get; set; }
        public int CodigoPncvautorizacaoInstalacaoEquipamentoSituacao { get; set; }
        public DateTime Data { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public string Descricao { get; set; }

        public virtual TblPncvautorizacaoInstalacaoEquipamento CodigoPncvautorizacaoInstalacaoEquipamentoNavigation { get; set; }
        public virtual TblPncvautorizacaoInstalacaoEquipamentoSituacao CodigoPncvautorizacaoInstalacaoEquipamentoSituacaoNavigation { get; set; }
    }
}
