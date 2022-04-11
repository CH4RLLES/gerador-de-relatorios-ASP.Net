using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal
    {
        public long CodigoInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal { get; set; }
        public long CodigoInfracaoIdentificacaoInfratorResponsavel { get; set; }
        public int CodigoInfracaoIdentificacaoInfratorResponsavelDocumentoFiscalTipo { get; set; }

        public virtual TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscalTipo CodigoInfracaoIdentificacaoInfratorResponsavelDocumentoFiscalTipoNavigation { get; set; }
        public virtual TblInfracaoIdentificacaoInfratorResponsavel CodigoInfracaoIdentificacaoInfratorResponsavelNavigation { get; set; }
    }
}
