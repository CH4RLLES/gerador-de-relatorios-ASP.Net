﻿using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblInfracaoPreAutuacaoPreparacaoImagem
    {
        public long CodigoInfracaoPreAutuacaoPreparacaoImagem { get; set; }
        public long CodigoInfracaoPreAutuacao { get; set; }
        public int CodigoInfracaoEnquadramento { get; set; }
        public int? CodigoSistemaUsuario { get; set; }
        public DateTime DataHoraInfracao { get; set; }
        public DateTime? DataEmPreparacaoImagem { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual TblInfracaoEnquadramento CodigoInfracaoEnquadramentoNavigation { get; set; }
        public virtual TblInfracaoPreAutuacao CodigoInfracaoPreAutuacaoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
