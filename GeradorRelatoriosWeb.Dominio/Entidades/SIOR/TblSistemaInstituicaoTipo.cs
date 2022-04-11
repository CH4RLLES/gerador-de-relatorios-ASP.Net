using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaInstituicaoTipo
    {
        public TblSistemaInstituicaoTipo()
        {
            TblSistemaInstituicao = new HashSet<TblSistemaInstituicao>();
        }

        public int CodigoSistemaInstituicaoTipo { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblSistemaInstituicao> TblSistemaInstituicao { get; set; }
    }
}
