using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseHoraFracao
    {
        public int CodigoBaseHoraFracao { get; set; }
        public byte HoraFracao { get; set; }
        public string FaixaHoraFracao { get; set; }
    }
}
