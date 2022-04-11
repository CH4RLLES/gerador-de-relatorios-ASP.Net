﻿using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalProjetoBasicoEntregaTrecho
    {
        public int CodigoBrlegalProjetoBasicoEntregaTrecho { get; set; }
        public int CodigoBrlegalProjetoBasicoEntrega { get; set; }
        public int CodigoSnvtrecho { get; set; }
        public decimal? KmInicial { get; set; }
        public decimal? KmFinal { get; set; }
        public decimal? Extensao { get; set; }
        public DateTime? DataAceite { get; set; }
        public string EngenheirosFiscais { get; set; }
        public string Observacao { get; set; }
        public int? CodigoBrlegalProjetoEntregaTrechoSituacao { get; set; }

        public virtual TblBrlegalProjetoBasicoEntrega CodigoBrlegalProjetoBasicoEntregaNavigation { get; set; }
        public virtual TblBrlegalProjetoEntregaTrechoSituacao CodigoBrlegalProjetoEntregaTrechoSituacaoNavigation { get; set; }
        public virtual TblSnvtrecho CodigoSnvtrechoNavigation { get; set; }
    }
}
