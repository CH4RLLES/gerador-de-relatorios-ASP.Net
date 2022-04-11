using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoProprietario
    {
        public TblInfracaoProprietario()
        {
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoProprietarioEndereco = new HashSet<TblInfracaoProprietarioEndereco>();
        }

        public long CodigoInfracaoProprietario { get; set; }
        public int CodigoRenavampossuidorOrigem { get; set; }
        public int CodigoRenavampossuidorTipoDocumento { get; set; }
        public int? CodigoRenavammodeloCnh { get; set; }
        public int? CodigoUfexpedicaoCnh { get; set; }
        public string Nome { get; set; }
        public string NumeroCpfcnpj { get; set; }
        public string NumeroCpfcnpjformatado { get; set; }
        public string NumeroRegistroCnh { get; set; }

        public virtual TblBaseUf CodigoUfexpedicaoCnhNavigation { get; set; }
        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoProprietarioEndereco> TblInfracaoProprietarioEndereco { get; set; }
    }
}
