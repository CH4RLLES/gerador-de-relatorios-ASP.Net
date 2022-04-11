using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblJariintegrante
    {
        public int CodigoJariintegrante { get; set; }
        public int CodigoJari { get; set; }
        public int CodigoJariintegranteTipo { get; set; }
        public int CodigoSistemaUsuario { get; set; }
        public int? CodigoJariintegranteVinculo { get; set; }

        public virtual TblJari CodigoJariNavigation { get; set; }
        public virtual TblJariintegranteTipo CodigoJariintegranteTipoNavigation { get; set; }
        public virtual TblJariintegranteVinculo CodigoJariintegranteVinculoNavigation { get; set; }
        public virtual TblSistemaUsuario CodigoSistemaUsuarioNavigation { get; set; }
    }
}
