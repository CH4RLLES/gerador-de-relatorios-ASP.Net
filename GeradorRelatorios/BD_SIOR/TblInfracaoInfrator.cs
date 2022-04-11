using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoInfrator
    {
        public TblInfracaoInfrator()
        {
            TblInfracao = new HashSet<TblInfracao>();
        }

        public long CodigoInfracaoInfrator { get; set; }
        public int? CodigoRenavammodeloCh { get; set; }
        public int? CodigoUfexpedicaoCnh { get; set; }
        public int? CodigoRenavampaisExpedicaoChestrangeira { get; set; }
        public int? CodigoRenavamtipoDocumentoCondutorNaoHabilitado { get; set; }
        public string Nome { get; set; }
        public string NumeroCpfcnpj { get; set; }
        public string NumeroCpfcnpjformatado { get; set; }
        public string NumeroRegistroCh { get; set; }
        public string NumeroDocumentoIdentificacao { get; set; }

        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
    }
}
