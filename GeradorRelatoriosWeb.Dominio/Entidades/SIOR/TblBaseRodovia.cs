using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseRodovia
    {
        public TblBaseRodovia()
        {
            TblBaseRodoviaUf = new HashSet<TblBaseRodoviaUf>();
            TblBrlegalDocumento = new HashSet<TblBrlegalDocumento>();
            TblBrlegalProjetoBasicoEntrega = new HashSet<TblBrlegalProjetoBasicoEntrega>();
            TblBrlegalProjetoExecutivoEntrega = new HashSet<TblBrlegalProjetoExecutivoEntrega>();
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoPreAutuacao = new HashSet<TblInfracaoPreAutuacao>();
            TblPesagemPosto = new HashSet<TblPesagemPosto>();
            TblPncvequipamento = new HashSet<TblPncvequipamento>();
            TblPncvestudoTecnicoInstalacao = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoMonitoramento = new HashSet<TblPncvestudoTecnicoMonitoramento>();
            TblPncvestudoViabilidade = new HashSet<TblPncvestudoViabilidade>();
            TblSegurancaAcidenteTransito = new HashSet<TblSegurancaAcidenteTransito>();
            TblSegurancaSegmentoCritico = new HashSet<TblSegurancaSegmentoCritico>();
            TblSegurancaSegmentoHomogeneo = new HashSet<TblSegurancaSegmentoHomogeneo>();
            TblSnvtrecho = new HashSet<TblSnvtrecho>();
            TblTrafegoVelocidadeMediaHorario = new HashSet<TblTrafegoVelocidadeMediaHorario>();
            TblTrafegoVelocidadeMediaSemanal = new HashSet<TblTrafegoVelocidadeMediaSemanal>();
            TblTrafegoVmdanual = new HashSet<TblTrafegoVmdanual>();
            TblTrafegoVmdanualClassificado = new HashSet<TblTrafegoVmdanualClassificado>();
            TblTrafegoVmdhorario = new HashSet<TblTrafegoVmdhorario>();
            TblTrafegoVmdhorarioClassificado = new HashSet<TblTrafegoVmdhorarioClassificado>();
            TblTrafegoVmdmensal = new HashSet<TblTrafegoVmdmensal>();
            TblTrafegoVmdmensalClassificado = new HashSet<TblTrafegoVmdmensalClassificado>();
            TblTrafegoVmdsemanal = new HashSet<TblTrafegoVmdsemanal>();
            TblTrafegoVmdsemanalClassificado = new HashSet<TblTrafegoVmdsemanalClassificado>();
        }

        public int CodigoBaseRodovia { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }

        public virtual ICollection<TblBaseRodoviaUf> TblBaseRodoviaUf { get; set; }
        public virtual ICollection<TblBrlegalDocumento> TblBrlegalDocumento { get; set; }
        public virtual ICollection<TblBrlegalProjetoBasicoEntrega> TblBrlegalProjetoBasicoEntrega { get; set; }
        public virtual ICollection<TblBrlegalProjetoExecutivoEntrega> TblBrlegalProjetoExecutivoEntrega { get; set; }
        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacao { get; set; }
        public virtual ICollection<TblPesagemPosto> TblPesagemPosto { get; set; }
        public virtual ICollection<TblPncvequipamento> TblPncvequipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacao { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramento { get; set; }
        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidade { get; set; }
        public virtual ICollection<TblSegurancaAcidenteTransito> TblSegurancaAcidenteTransito { get; set; }
        public virtual ICollection<TblSegurancaSegmentoCritico> TblSegurancaSegmentoCritico { get; set; }
        public virtual ICollection<TblSegurancaSegmentoHomogeneo> TblSegurancaSegmentoHomogeneo { get; set; }
        public virtual ICollection<TblSnvtrecho> TblSnvtrecho { get; set; }
        public virtual ICollection<TblTrafegoVelocidadeMediaHorario> TblTrafegoVelocidadeMediaHorario { get; set; }
        public virtual ICollection<TblTrafegoVelocidadeMediaSemanal> TblTrafegoVelocidadeMediaSemanal { get; set; }
        public virtual ICollection<TblTrafegoVmdanual> TblTrafegoVmdanual { get; set; }
        public virtual ICollection<TblTrafegoVmdanualClassificado> TblTrafegoVmdanualClassificado { get; set; }
        public virtual ICollection<TblTrafegoVmdhorario> TblTrafegoVmdhorario { get; set; }
        public virtual ICollection<TblTrafegoVmdhorarioClassificado> TblTrafegoVmdhorarioClassificado { get; set; }
        public virtual ICollection<TblTrafegoVmdmensal> TblTrafegoVmdmensal { get; set; }
        public virtual ICollection<TblTrafegoVmdmensalClassificado> TblTrafegoVmdmensalClassificado { get; set; }
        public virtual ICollection<TblTrafegoVmdsemanal> TblTrafegoVmdsemanal { get; set; }
        public virtual ICollection<TblTrafegoVmdsemanalClassificado> TblTrafegoVmdsemanalClassificado { get; set; }
    }
}
