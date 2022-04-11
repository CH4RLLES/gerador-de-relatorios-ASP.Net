using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSnvtrechoSuperficie
    {
        public TblSnvtrechoSuperficie()
        {
            TblSnvtrechoHistoricoCodigoSnvtrechoSuperficieEstadualCoincidenteNavigation = new HashSet<TblSnvtrechoHistorico>();
            TblSnvtrechoHistoricoCodigoSnvtrechoSuperficieNavigation = new HashSet<TblSnvtrechoHistorico>();
        }

        public int CodigoSnvtrechoSuperficie { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool IndicadorSuperficiePavimentada { get; set; }

        public virtual ICollection<TblSnvtrechoHistorico> TblSnvtrechoHistoricoCodigoSnvtrechoSuperficieEstadualCoincidenteNavigation { get; set; }
        public virtual ICollection<TblSnvtrechoHistorico> TblSnvtrechoHistoricoCodigoSnvtrechoSuperficieNavigation { get; set; }
    }
}
