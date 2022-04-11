using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvsolicitacaoTransferenciaContratoEvento
    {
        public int CodigoPncvsolicitacaoTransferenciaContratoEvento { get; set; }
        public int CodigoPncvsolicitacaoTransferenciaContratoSituacao { get; set; }
        public int CodigoPncvsolicitacaoTransferenciaContrato { get; set; }
        public string NomeSistemaUsuario { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public virtual TblPncvsolicitacaoTransferenciaContrato CodigoPncvsolicitacaoTransferenciaContratoNavigation { get; set; }
        public virtual TblPncvsolicitacaoTransferenciaContratoSituacao CodigoPncvsolicitacaoTransferenciaContratoSituacaoNavigation { get; set; }
    }
}
