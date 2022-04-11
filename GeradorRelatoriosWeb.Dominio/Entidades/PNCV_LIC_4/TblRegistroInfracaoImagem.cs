using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class TblRegistroInfracaoImagem
    {
        public long CodigoRegistroInfracaoImagem { get; set; }
        public long CodigoRegistroInfracao { get; set; }
        public int CodigoRegistroInfracaoImagemTipo { get; set; }
        public int? CodigoRegistroInfracaoImagemMotivoReinicioSequencia { get; set; }
        public string Nome { get; set; }
        public string NomeFisico { get; set; }
        public int Tamanho { get; set; }
        public DateTime DataHora { get; set; }
        public int SequenciaImagem { get; set; }

        public virtual TblRegistroInfracaoImagemMotivoReinicioSequencia CodigoRegistroInfracaoImagemMotivoReinicioSequenciaNavigation { get; set; }
        public virtual TblRegistroInfracaoImagemTipo CodigoRegistroInfracaoImagemTipoNavigation { get; set; }
        public virtual TblRegistroInfracao CodigoRegistroInfracaoNavigation { get; set; }
    }
}
