using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvestudoViabilidadeEvento
    {
        public int CodigoPncvestudoViabilidadeEvento { get; set; }
        public int CodigoPncvestudoViabilidade { get; set; }
        public int CodigoPncvestudoViabilidadeSituacao { get; set; }
        public DateTime? Data { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblPncvestudoViabilidade CodigoPncvestudoViabilidadeNavigation { get; set; }
        public virtual TblPncvestudoViabilidadeSituacao CodigoPncvestudoViabilidadeSituacaoNavigation { get; set; }
    }
}
