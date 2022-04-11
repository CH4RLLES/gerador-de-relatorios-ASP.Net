using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoCondutor
    {
        public TblInfracaoCondutor()
        {
            TblInfracao = new HashSet<TblInfracao>();
        }

        public long CodigoInfracaoCondutor { get; set; }
        public int? CodigoRenavammodeloCh { get; set; }
        public int? CodigoRenavamtipoDocumentoCondutorNaoHabilitado { get; set; }
        public int? CodigoRenavampaisExpedicaoChestrangeira { get; set; }
        public int? CodigoUfexpedicaoCnh { get; set; }
        public string Nome { get; set; }
        public string NumeroCpf { get; set; }
        public string NumeroCpfformatado { get; set; }
        public string NumeroRegistroCh { get; set; }
        public string NumeroDocumentoIdentificacao { get; set; }

        public virtual TblBaseUf CodigoUfexpedicaoCnhNavigation { get; set; }
        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
    }
}
