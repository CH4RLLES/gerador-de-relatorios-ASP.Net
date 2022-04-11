using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscalTipo
    {
        public TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscalTipo()
        {
            TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal = new HashSet<TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal>();
        }

        public int CodigoInfracaoIdentificacaoInfratorResponsavelDocumentoFiscalTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal> TblInfracaoIdentificacaoInfratorResponsavelDocumentoFiscal { get; set; }
    }
}
