using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorResponsavelEvento
    {
        public long CodigoInfracaoIdentificacaoInfratorResponsavelEvento { get; set; }
        public long CodigoInfracaoIdentificacaoInfratorResponsavel { get; set; }
        public int CodigoInfracaoIdentificacaoInfratorResponsavelSituacao { get; set; }
        public int CodigoInfracaoIdentificacaoInfratorResponsavelFase { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoIdentificacaoInfratorResponsavelFase CodigoInfracaoIdentificacaoInfratorResponsavelFaseNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorResponsavel CodigoInfracaoIdentificacaoInfratorResponsavelNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorResponsavelSituacao CodigoInfracaoIdentificacaoInfratorResponsavelSituacaoNavigation { get; set; }
    }
}
