using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoImagem
    {
        public long CodigoInfracaoImagem { get; set; }
        public long CodigoInfracao { get; set; }
        public int? CodigoInfracaoImagemTipo { get; set; }
        public string Nome { get; set; }
        public string NomeFisico { get; set; }
        public int Tamanho { get; set; }
        public int? NumeroSequencia { get; set; }

        public virtual TblInfracaoImagemTipo CodigoInfracaoImagemTipoNavigation { get; set; }
        public virtual TblInfracao CodigoInfracaoNavigation { get; set; }
    }
}
