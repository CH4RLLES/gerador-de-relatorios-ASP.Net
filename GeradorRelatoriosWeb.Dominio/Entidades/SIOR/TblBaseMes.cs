using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseMes
    {
        public TblBaseMes()
        {
            TblTrafegoVelocidadeMediaHorario = new HashSet<TblTrafegoVelocidadeMediaHorario>();
            TblTrafegoVelocidadeMediaSemanal = new HashSet<TblTrafegoVelocidadeMediaSemanal>();
            TblTrafegoVmdhorario = new HashSet<TblTrafegoVmdhorario>();
            TblTrafegoVmdhorarioClassificado = new HashSet<TblTrafegoVmdhorarioClassificado>();
            TblTrafegoVmdmensalClassificado = new HashSet<TblTrafegoVmdmensalClassificado>();
            TblTrafegoVmdsemanal = new HashSet<TblTrafegoVmdsemanal>();
            TblTrafegoVmdsemanalClassificado = new HashSet<TblTrafegoVmdsemanalClassificado>();
        }

        public int CodigoBaseMes { get; set; }
        public byte Numero { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblTrafegoVelocidadeMediaHorario> TblTrafegoVelocidadeMediaHorario { get; set; }
        public virtual ICollection<TblTrafegoVelocidadeMediaSemanal> TblTrafegoVelocidadeMediaSemanal { get; set; }
        public virtual ICollection<TblTrafegoVmdhorario> TblTrafegoVmdhorario { get; set; }
        public virtual ICollection<TblTrafegoVmdhorarioClassificado> TblTrafegoVmdhorarioClassificado { get; set; }
        public virtual ICollection<TblTrafegoVmdmensalClassificado> TblTrafegoVmdmensalClassificado { get; set; }
        public virtual ICollection<TblTrafegoVmdsemanal> TblTrafegoVmdsemanal { get; set; }
        public virtual ICollection<TblTrafegoVmdsemanalClassificado> TblTrafegoVmdsemanalClassificado { get; set; }
    }
}
