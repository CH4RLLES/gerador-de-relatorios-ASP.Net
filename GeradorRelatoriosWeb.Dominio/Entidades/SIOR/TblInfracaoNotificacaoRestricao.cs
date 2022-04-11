using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoNotificacaoRestricao
    {
        public TblInfracaoNotificacaoRestricao()
        {
            TblInfracaoNotificacaoRestricaoArquivo = new HashSet<TblInfracaoNotificacaoRestricaoArquivo>();
            TblInfracaoNotificacaoRestricaoEvento = new HashSet<TblInfracaoNotificacaoRestricaoEvento>();
            TblInfracaoNotificacaoRestricaoPncvequipamento = new HashSet<TblInfracaoNotificacaoRestricaoPncvequipamento>();
        }

        public int CodigoInfracaoNotificacaoRestricao { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public bool IndicadorRestricaoAtiva { get; set; }
        public bool IndicadorRestricaoNa { get; set; }
        public bool IndicadorRestricaoNp { get; set; }
        public DateTime? PrazoVigenciaInicio { get; set; }
        public DateTime? PrazoVigenciaTermino { get; set; }

        public virtual ICollection<TblInfracaoNotificacaoRestricaoArquivo> TblInfracaoNotificacaoRestricaoArquivo { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoRestricaoEvento> TblInfracaoNotificacaoRestricaoEvento { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoRestricaoPncvequipamento> TblInfracaoNotificacaoRestricaoPncvequipamento { get; set; }
    }
}
