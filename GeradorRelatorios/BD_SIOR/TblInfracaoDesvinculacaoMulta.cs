using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoDesvinculacaoMulta
    {
        public TblInfracaoDesvinculacaoMulta()
        {
            TblInfracaoDesvinculacaoMultaArquivo = new HashSet<TblInfracaoDesvinculacaoMultaArquivo>();
            TblInfracaoDesvinculacaoMultaEvento = new HashSet<TblInfracaoDesvinculacaoMultaEvento>();
        }

        public long CodigoInfracaoDesvinculacaoMulta { get; set; }
        public long CodigoInfracao { get; set; }
        public int CodigoInfracaoDesvinculacaoMultaSituacao { get; set; }
        public int CodigoInfracaoDesvinculacaoMultaOrigem { get; set; }
        public int CodigoRenavammotivoDesvinculacao { get; set; }
        public string NumeroProcesso { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public string Observacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public byte[] RowVersion { get; set; }
        public bool IndicadorRegistroRenainf { get; set; }

        public virtual TblInfracaoDesvinculacaoMultaOrigem CodigoInfracaoDesvinculacaoMultaOrigemNavigation { get; set; }
        public virtual TblInfracaoDesvinculacaoMultaSituacao CodigoInfracaoDesvinculacaoMultaSituacaoNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoDesvinculacaoMultaArquivo> TblInfracaoDesvinculacaoMultaArquivo { get; set; }
        public virtual ICollection<TblInfracaoDesvinculacaoMultaEvento> TblInfracaoDesvinculacaoMultaEvento { get; set; }
    }
}
