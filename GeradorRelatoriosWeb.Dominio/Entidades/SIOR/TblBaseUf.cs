using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBaseUf
    {
        public TblBaseUf()
        {
            TblBaseMunicipio = new HashSet<TblBaseMunicipio>();
            TblBaseRodoviaUf = new HashSet<TblBaseRodoviaUf>();
            TblBrlegalContrato = new HashSet<TblBrlegalContrato>();
            TblBrlegalEmpresa = new HashSet<TblBrlegalEmpresa>();
            TblBrlegalProjetoBasicoEntrega = new HashSet<TblBrlegalProjetoBasicoEntrega>();
            TblBrlegalProjetoExecutivoEntrega = new HashSet<TblBrlegalProjetoExecutivoEntrega>();
            TblInfracao = new HashSet<TblInfracao>();
            TblInfracaoCondutor = new HashSet<TblInfracaoCondutor>();
            TblInfracaoIdentificacaoInfratorCondutor = new HashSet<TblInfracaoIdentificacaoInfratorCondutor>();
            TblInfracaoNotificacao = new HashSet<TblInfracaoNotificacao>();
            TblInfracaoPreAutuacaoCodigoUfjurisdicaoVeiculoNavigation = new HashSet<TblInfracaoPreAutuacao>();
            TblInfracaoPreAutuacaoCodigoUflocalInfracaoNavigation = new HashSet<TblInfracaoPreAutuacao>();
            TblInfracaoPreAutuacaoConferenciaDupla = new HashSet<TblInfracaoPreAutuacaoConferenciaDupla>();
            TblInfracaoProprietario = new HashSet<TblInfracaoProprietario>();
            TblInfracaoProprietarioEndereco = new HashSet<TblInfracaoProprietarioEndereco>();
            TblInfracaoVeiculo = new HashSet<TblInfracaoVeiculo>();
            TblJari = new HashSet<TblJari>();
            TblPesagemPosto = new HashSet<TblPesagemPosto>();
            TblPncvagenteTransitoCredenciamento = new HashSet<TblPncvagenteTransitoCredenciamento>();
            TblPncvagenteTransitoCredenciamentoCredencial = new HashSet<TblPncvagenteTransitoCredenciamentoCredencial>();
            TblPncvagenteTransitoSolicitacaoCredenciamento = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamento>();
            TblPncveditalLoteAbrangencia = new HashSet<TblPncveditalLoteAbrangencia>();
            TblPncvequipamento = new HashSet<TblPncvequipamento>();
            TblPncvestudoTecnicoInstalacao = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoMonitoramento = new HashSet<TblPncvestudoTecnicoMonitoramento>();
            TblPncvestudoViabilidade = new HashSet<TblPncvestudoViabilidade>();
            TblSegurancaAcidenteTransito = new HashSet<TblSegurancaAcidenteTransito>();
            TblSegurancaSegmentoCritico = new HashSet<TblSegurancaSegmentoCritico>();
            TblSegurancaSegmentoHomogeneo = new HashSet<TblSegurancaSegmentoHomogeneo>();
            TblSistemaUsuario = new HashSet<TblSistemaUsuario>();
            TblSistemaUsuarioPncvabrangencia = new HashSet<TblSistemaUsuarioPncvabrangencia>();
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

        public int CodigoBaseUf { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<TblBaseMunicipio> TblBaseMunicipio { get; set; }
        public virtual ICollection<TblBaseRodoviaUf> TblBaseRodoviaUf { get; set; }
        public virtual ICollection<TblBrlegalContrato> TblBrlegalContrato { get; set; }
        public virtual ICollection<TblBrlegalEmpresa> TblBrlegalEmpresa { get; set; }
        public virtual ICollection<TblBrlegalProjetoBasicoEntrega> TblBrlegalProjetoBasicoEntrega { get; set; }
        public virtual ICollection<TblBrlegalProjetoExecutivoEntrega> TblBrlegalProjetoExecutivoEntrega { get; set; }
        public virtual ICollection<TblInfracao> TblInfracao { get; set; }
        public virtual ICollection<TblInfracaoCondutor> TblInfracaoCondutor { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutor> TblInfracaoIdentificacaoInfratorCondutor { get; set; }
        public virtual ICollection<TblInfracaoNotificacao> TblInfracaoNotificacao { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacaoCodigoUfjurisdicaoVeiculoNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacao> TblInfracaoPreAutuacaoCodigoUflocalInfracaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaDupla> TblInfracaoPreAutuacaoConferenciaDupla { get; set; }
        public virtual ICollection<TblInfracaoProprietario> TblInfracaoProprietario { get; set; }
        public virtual ICollection<TblInfracaoProprietarioEndereco> TblInfracaoProprietarioEndereco { get; set; }
        public virtual ICollection<TblInfracaoVeiculo> TblInfracaoVeiculo { get; set; }
        public virtual ICollection<TblJari> TblJari { get; set; }
        public virtual ICollection<TblPesagemPosto> TblPesagemPosto { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamentoCredencial> TblPncvagenteTransitoCredenciamentoCredencial { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamento> TblPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public virtual ICollection<TblPncveditalLoteAbrangencia> TblPncveditalLoteAbrangencia { get; set; }
        public virtual ICollection<TblPncvequipamento> TblPncvequipamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacao { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramento { get; set; }
        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidade { get; set; }
        public virtual ICollection<TblSegurancaAcidenteTransito> TblSegurancaAcidenteTransito { get; set; }
        public virtual ICollection<TblSegurancaSegmentoCritico> TblSegurancaSegmentoCritico { get; set; }
        public virtual ICollection<TblSegurancaSegmentoHomogeneo> TblSegurancaSegmentoHomogeneo { get; set; }
        public virtual ICollection<TblSistemaUsuario> TblSistemaUsuario { get; set; }
        public virtual ICollection<TblSistemaUsuarioPncvabrangencia> TblSistemaUsuarioPncvabrangencia { get; set; }
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
