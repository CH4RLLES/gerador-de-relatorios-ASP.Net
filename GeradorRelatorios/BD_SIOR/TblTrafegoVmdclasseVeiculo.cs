using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblTrafegoVmdclasseVeiculo
    {
        public TblTrafegoVmdclasseVeiculo()
        {
            TblTrafegoVmdanualClassificadoClasseVeiculo = new HashSet<TblTrafegoVmdanualClassificadoClasseVeiculo>();
            TblTrafegoVmdhorarioClassificadoClasseVeiculo = new HashSet<TblTrafegoVmdhorarioClassificadoClasseVeiculo>();
            TblTrafegoVmdmensalClassificadoClasseVeiculo = new HashSet<TblTrafegoVmdmensalClassificadoClasseVeiculo>();
            TblTrafegoVmdsemanalClassificadoClasseVeiculo = new HashSet<TblTrafegoVmdsemanalClassificadoClasseVeiculo>();
        }

        public int CodigoTrafegoVmdclasseVeiculo { get; set; }
        public int CodigoTrafegoVmdfonteDados { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual TblTrafegoVmdfonteDados CodigoTrafegoVmdfonteDadosNavigation { get; set; }
        public virtual ICollection<TblTrafegoVmdanualClassificadoClasseVeiculo> TblTrafegoVmdanualClassificadoClasseVeiculo { get; set; }
        public virtual ICollection<TblTrafegoVmdhorarioClassificadoClasseVeiculo> TblTrafegoVmdhorarioClassificadoClasseVeiculo { get; set; }
        public virtual ICollection<TblTrafegoVmdmensalClassificadoClasseVeiculo> TblTrafegoVmdmensalClassificadoClasseVeiculo { get; set; }
        public virtual ICollection<TblTrafegoVmdsemanalClassificadoClasseVeiculo> TblTrafegoVmdsemanalClassificadoClasseVeiculo { get; set; }
    }
}
