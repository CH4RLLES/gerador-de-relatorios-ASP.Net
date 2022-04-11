using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblTrafegoVmdfonteDados
    {
        public TblTrafegoVmdfonteDados()
        {
            TblTrafegoVmdanual = new HashSet<TblTrafegoVmdanual>();
            TblTrafegoVmdanualClassificado = new HashSet<TblTrafegoVmdanualClassificado>();
            TblTrafegoVmdclasseVeiculo = new HashSet<TblTrafegoVmdclasseVeiculo>();
            TblTrafegoVmdhorario = new HashSet<TblTrafegoVmdhorario>();
            TblTrafegoVmdhorarioClassificado = new HashSet<TblTrafegoVmdhorarioClassificado>();
            TblTrafegoVmdmensal = new HashSet<TblTrafegoVmdmensal>();
            TblTrafegoVmdmensalClassificado = new HashSet<TblTrafegoVmdmensalClassificado>();
            TblTrafegoVmdsemanal = new HashSet<TblTrafegoVmdsemanal>();
            TblTrafegoVmdsemanalClassificado = new HashSet<TblTrafegoVmdsemanalClassificado>();
        }

        public int CodigoTrafegoVmdfonteDados { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblTrafegoVmdanual> TblTrafegoVmdanual { get; set; }
        public virtual ICollection<TblTrafegoVmdanualClassificado> TblTrafegoVmdanualClassificado { get; set; }
        public virtual ICollection<TblTrafegoVmdclasseVeiculo> TblTrafegoVmdclasseVeiculo { get; set; }
        public virtual ICollection<TblTrafegoVmdhorario> TblTrafegoVmdhorario { get; set; }
        public virtual ICollection<TblTrafegoVmdhorarioClassificado> TblTrafegoVmdhorarioClassificado { get; set; }
        public virtual ICollection<TblTrafegoVmdmensal> TblTrafegoVmdmensal { get; set; }
        public virtual ICollection<TblTrafegoVmdmensalClassificado> TblTrafegoVmdmensalClassificado { get; set; }
        public virtual ICollection<TblTrafegoVmdsemanal> TblTrafegoVmdsemanal { get; set; }
        public virtual ICollection<TblTrafegoVmdsemanalClassificado> TblTrafegoVmdsemanalClassificado { get; set; }
    }
}
