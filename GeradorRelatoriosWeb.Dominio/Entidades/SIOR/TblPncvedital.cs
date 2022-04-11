using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvedital
    {
        public TblPncvedital()
        {
            TblPncveditalLote = new HashSet<TblPncveditalLote>();
        }

        public int CodigoPncvedital { get; set; }
        public string Numero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string ArquivoReferenciaNome { get; set; }
        public string ArquivoReferenciaNomeFisico { get; set; }
        public int ArquivoReferenciaTamanho { get; set; }
        public int CodigoPncveditalObjeto { get; set; }

        public virtual TblPncveditalObjeto CodigoPncveditalObjetoNavigation { get; set; }
        public virtual ICollection<TblPncveditalLote> TblPncveditalLote { get; set; }
    }
}
