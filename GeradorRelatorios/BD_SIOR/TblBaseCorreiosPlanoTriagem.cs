using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseCorreiosPlanoTriagem
    {
        public TblBaseCorreiosPlanoTriagem()
        {
            TblBaseCorreiosPlanoTriagemFaixaCep = new HashSet<TblBaseCorreiosPlanoTriagemFaixaCep>();
            TblInfracaoNotificacaoExpedicao = new HashSet<TblInfracaoNotificacaoExpedicao>();
        }

        public int CodigoBaseCorreiosPlanoTriagem { get; set; }
        public int CodigoInfracaoNotificacaoExpedicaoServico { get; set; }
        public string Versao { get; set; }
        public string Descricao { get; set; }
        public DateTime VigenciaDataInicio { get; set; }
        public DateTime? VigenciaDataTermino { get; set; }
        public int QuantidadeFaixaCep { get; set; }

        public virtual TblInfracaoNotificacaoExpedicaoServico CodigoInfracaoNotificacaoExpedicaoServicoNavigation { get; set; }
        public virtual ICollection<TblBaseCorreiosPlanoTriagemFaixaCep> TblBaseCorreiosPlanoTriagemFaixaCep { get; set; }
        public virtual ICollection<TblInfracaoNotificacaoExpedicao> TblInfracaoNotificacaoExpedicao { get; set; }
    }
}
