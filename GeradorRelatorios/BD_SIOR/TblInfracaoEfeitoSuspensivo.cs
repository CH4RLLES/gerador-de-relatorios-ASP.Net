using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoEfeitoSuspensivo
    {
        public TblInfracaoEfeitoSuspensivo()
        {
            TblInfracaoEfeitoSuspensivoArquivo = new HashSet<TblInfracaoEfeitoSuspensivoArquivo>();
            TblInfracaoEfeitoSuspensivoEvento = new HashSet<TblInfracaoEfeitoSuspensivoEvento>();
        }

        public long CodigoInfracaoEfeitoSuspensivo { get; set; }
        public int CodigoInfracaoEfeitoSuspensivoSituacao { get; set; }
        public int CodigoInfracaoEfeitoSuspensivoFase { get; set; }
        public int CodigoInfracaoEfeitoSuspensivoTipo { get; set; }
        public long CodigoInfracao { get; set; }
        public bool IndicadorRegistroRenainf { get; set; }
        public string NumeroProcesso { get; set; }
        public DateTime DataProtocolo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAnulacao { get; set; }
        public string Observacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual TblInfracaoEfeitoSuspensivoFase CodigoInfracaoEfeitoSuspensivoFaseNavigation { get; set; }
        public virtual TblInfracaoEfeitoSuspensivoSituacao CodigoInfracaoEfeitoSuspensivoSituacaoNavigation { get; set; }
        public virtual TblInfracaoEfeitoSuspensivoTipo CodigoInfracaoEfeitoSuspensivoTipoNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoEfeitoSuspensivoArquivo> TblInfracaoEfeitoSuspensivoArquivo { get; set; }
        public virtual ICollection<TblInfracaoEfeitoSuspensivoEvento> TblInfracaoEfeitoSuspensivoEvento { get; set; }
    }
}
