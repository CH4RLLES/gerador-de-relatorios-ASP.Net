using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoInstalacaoEvento
    {
        public int CodigoPncvestudoTecnicoInstalacaoEvento { get; set; }
        public int CodigoPncvestudoTecnicoInstalacao { get; set; }
        public int CodigoPncvestudoTecnicoInstalacaoSituacao { get; set; }
        public DateTime? Data { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacaoSituacao CodigoPncvestudoTecnicoInstalacaoSituacaoNavigation { get; set; }
    }
}
