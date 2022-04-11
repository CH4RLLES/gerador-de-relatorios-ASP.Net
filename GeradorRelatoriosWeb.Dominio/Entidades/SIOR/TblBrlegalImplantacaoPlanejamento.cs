using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalImplantacaoPlanejamento
    {
        public TblBrlegalImplantacaoPlanejamento()
        {
            TblBrlegalImplantacaoPlanejamentoEvento = new HashSet<TblBrlegalImplantacaoPlanejamentoEvento>();
            TblBrlegalImplantacaoProjetoCronograma = new HashSet<TblBrlegalImplantacaoProjetoCronograma>();
            TblBrlegalImplantacaoTrechoCronograma = new HashSet<TblBrlegalImplantacaoTrechoCronograma>();
        }

        public int CodigoBrlegalImplantacaoPlanejamento { get; set; }
        public int CodigoBrlegalContrato { get; set; }
        public int CodigoBrlegalImplantacaoPlanejamentoSituacao { get; set; }
        public DateTime Versao { get; set; }

        public virtual TblBrlegalContrato CodigoBrlegalContratoNavigation { get; set; }
        public virtual TblBrlegalImplantacaoPlanejamentoSituacao CodigoBrlegalImplantacaoPlanejamentoSituacaoNavigation { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoPlanejamentoEvento> TblBrlegalImplantacaoPlanejamentoEvento { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoProjetoCronograma> TblBrlegalImplantacaoProjetoCronograma { get; set; }
        public virtual ICollection<TblBrlegalImplantacaoTrechoCronograma> TblBrlegalImplantacaoTrechoCronograma { get; set; }
    }
}
