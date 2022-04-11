using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoDanaoConhecer
    {
        public long CodigoInfracaoDanaoConhecer { get; set; }
        public long CodigoInfracaoDa { get; set; }
        public int CodigoInfracaoDacausaNaoConhecer { get; set; }

        public virtual TblInfracaoDa CodigoInfracaoDaNavigation { get; set; }
        public virtual TblInfracaoDacausaNaoConhecer CodigoInfracaoDacausaNaoConhecerNavigation { get; set; }
    }
}
