using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoTecnicoInstalacaoFoto
    {
        public int CodigoPncvestudoTecnicoInstalacaoFoto { get; set; }
        public int CodigoPncvestudoTecnicoInstalacao { get; set; }
        public string Descricao { get; set; }
        public string ArquivoNome { get; set; }
        public string ArquivoNomeFisico { get; set; }
        public int? ArquivoTamanho { get; set; }

        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
    }
}
