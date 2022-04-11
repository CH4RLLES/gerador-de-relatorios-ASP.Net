using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSnvtrechoHistorico
    {
        public TblSnvtrechoHistorico()
        {
            TblSnvtrechoCoincidenteCodigoSnvtrechoHistoricoCoincidenteNavigation = new HashSet<TblSnvtrechoCoincidente>();
            TblSnvtrechoCoincidenteCodigoSnvtrechoHistoricoNavigation = new HashSet<TblSnvtrechoCoincidente>();
        }

        public int CodigoSnvtrechoHistorico { get; set; }
        public int CodigoSnvtrecho { get; set; }
        public int CodigoSnvtrechoSuperficie { get; set; }
        public int? CodigoSnvtrechoSuperficieEstadualCoincidente { get; set; }
        public int? CodigoSnvtrechoOcupacao { get; set; }
        public int AnoReferencia { get; set; }
        public decimal QuilometroInicio { get; set; }
        public decimal QuilometroFim { get; set; }
        public string DescricaoLocalInicio { get; set; }
        public string DescricaoLocalFim { get; set; }
        public decimal Extensao { get; set; }
        public string SiglaRodoviaEstadualCoincidente { get; set; }
        public short? Mp082 { get; set; }
        public bool IndicadorProvisorio { get; set; }
        public string ConcessaoConvenio { get; set; }
        public int? CodigoSnvtrechoTipo { get; set; }

        public virtual TblSnvtrecho CodigoSnvtrechoNavigation { get; set; }
        public virtual TblSnvtrechoOcupacao CodigoSnvtrechoOcupacaoNavigation { get; set; }
        public virtual TblSnvtrechoSuperficie CodigoSnvtrechoSuperficieEstadualCoincidenteNavigation { get; set; }
        public virtual TblSnvtrechoSuperficie CodigoSnvtrechoSuperficieNavigation { get; set; }
        public virtual TblSnvtrechoTipo CodigoSnvtrechoTipoNavigation { get; set; }
        public virtual ICollection<TblSnvtrechoCoincidente> TblSnvtrechoCoincidenteCodigoSnvtrechoHistoricoCoincidenteNavigation { get; set; }
        public virtual ICollection<TblSnvtrechoCoincidente> TblSnvtrechoCoincidenteCodigoSnvtrechoHistoricoNavigation { get; set; }
    }
}
