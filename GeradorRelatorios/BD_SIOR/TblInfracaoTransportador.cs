using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoTransportador
    {
        public TblInfracaoTransportador()
        {
            TblInfracao = new HashSet<TblInfracao>();
        }

        public long CodigoInfracaoTransportador { get; set; }
        public int CodigoRenavamtipoDocumentoEmbarcadorTransportador { get; set; }
        public string Nome { get; set; }
        public string NumeroCpfcnpj { get; set; }
        public string NumeroCpfcnpjformatado { get; set; }

        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
    }
}
