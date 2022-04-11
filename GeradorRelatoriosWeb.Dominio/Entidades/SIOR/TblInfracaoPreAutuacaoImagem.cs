using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoPreAutuacaoImagem
    {
        public long CodigoInfracaoPreAutuacaoImagem { get; set; }
        public long CodigoInfracaoPreAutuacao { get; set; }
        public int? CodigoInfracaoImagemTipo { get; set; }
        public string Nome { get; set; }
        public string NomeFisico { get; set; }
        public int Tamanho { get; set; }
        public int? NumeroSequencia { get; set; }

        public virtual TblInfracaoImagemTipo CodigoInfracaoImagemTipoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacao CodigoInfracaoPreAutuacaoNavigation { get; set; }
    }
}
