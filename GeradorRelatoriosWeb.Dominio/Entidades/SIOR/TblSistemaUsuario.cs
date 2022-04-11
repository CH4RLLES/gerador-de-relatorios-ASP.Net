using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaUsuario
    {
        public TblSistemaUsuario()
        {
            TblCobrancaInfracaoCodigoUsuarioAnaliseProcessualNavigation = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoCodigoUsuarioCadastroSapiensNavigation = new HashSet<TblCobrancaInfracao>();
            TblCobrancaInfracaoCodigoUsuarioRevisaoProcessualNavigation = new HashSet<TblCobrancaInfracao>();
            TblInfracaoDa = new HashSet<TblInfracaoDa>();
            TblInfracaoIdentificacaoInfratorCondutor = new HashSet<TblInfracaoIdentificacaoInfratorCondutor>();
            TblInfracaoIdentificacaoInfratorResponsavel = new HashSet<TblInfracaoIdentificacaoInfratorResponsavel>();
            TblInfracaoPreAutuacaoAnalise = new HashSet<TblInfracaoPreAutuacaoAnalise>();
            TblInfracaoPreAutuacaoConferenciaDuplaCodigoSistemaUsuarioConferenciaDoisNavigation = new HashSet<TblInfracaoPreAutuacaoConferenciaDupla>();
            TblInfracaoPreAutuacaoConferenciaDuplaCodigoSistemaUsuarioConferenciaRevisaoNavigation = new HashSet<TblInfracaoPreAutuacaoConferenciaDupla>();
            TblInfracaoPreAutuacaoConferenciaDuplaCodigoSistemaUsuarioConferenciaUmNavigation = new HashSet<TblInfracaoPreAutuacaoConferenciaDupla>();
            TblInfracaoPreAutuacaoPreparacaoImagem = new HashSet<TblInfracaoPreAutuacaoPreparacaoImagem>();
            TblInfracaoRecursoAnaliseJulgamentoJari = new HashSet<TblInfracaoRecursoAnaliseJulgamentoJari>();
            TblInfracaoRecursoCodigoSistemaUsuarioEmVistasNavigation = new HashSet<TblInfracaoRecurso>();
            TblInfracaoRecursoCodigoSistemaUsuarioInstrucaoNavigation = new HashSet<TblInfracaoRecurso>();
            TblInfracaoRecursoCodigoSistemaUsuarioRelatoNavigation = new HashSet<TblInfracaoRecurso>();
            TblInfracaoRecursoCodigoSistemaUsuarioRevisaoNavigation = new HashSet<TblInfracaoRecurso>();
            TblInfracaoSolicitacaoAdvertencia = new HashSet<TblInfracaoSolicitacaoAdvertencia>();
            TblJariintegrante = new HashSet<TblJariintegrante>();
            TblJarisessaoJulgamentoColegiado = new HashSet<TblJarisessaoJulgamentoColegiado>();
            TblJarisessaoJulgamentoVoto = new HashSet<TblJarisessaoJulgamentoVoto>();
            TblPncvagenteTransitoCredenciamento = new HashSet<TblPncvagenteTransitoCredenciamento>();
            TblPncvagenteTransitoSolicitacaoCredenciamento = new HashSet<TblPncvagenteTransitoSolicitacaoCredenciamento>();
            TblPncvestudoTecnicoInstalacaoCodigoSistemaUsuarioAnaliseNavigation = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoInstalacaoCodigoSistemaUsuarioElaboracaoNavigation = new HashSet<TblPncvestudoTecnicoInstalacao>();
            TblPncvestudoTecnicoMonitoramentoCodigoSistemaUsuarioAnaliseNavigation = new HashSet<TblPncvestudoTecnicoMonitoramento>();
            TblPncvestudoTecnicoMonitoramentoCodigoSistemaUsuarioElaboracaoNavigation = new HashSet<TblPncvestudoTecnicoMonitoramento>();
            TblPncvestudoViabilidadeCodigoSistemaUsuarioAnaliseNavigation = new HashSet<TblPncvestudoViabilidade>();
            TblPncvestudoViabilidadeCodigoSistemaUsuarioElaboracaoNavigation = new HashSet<TblPncvestudoViabilidade>();
            TblSistemaUsuarioAcao = new HashSet<TblSistemaUsuarioAcao>();
            TblSistemaUsuarioBrlegalContrato = new HashSet<TblSistemaUsuarioBrlegalContrato>();
            TblSistemaUsuarioEvento = new HashSet<TblSistemaUsuarioEvento>();
            TblSistemaUsuarioFavorito = new HashSet<TblSistemaUsuarioFavorito>();
            TblSistemaUsuarioMenu = new HashSet<TblSistemaUsuarioMenu>();
            TblSistemaUsuarioPerfil = new HashSet<TblSistemaUsuarioPerfil>();
            TblSistemaUsuarioPncvabrangencia = new HashSet<TblSistemaUsuarioPncvabrangencia>();
            TblSistemaUsuarioPncveditalLote = new HashSet<TblSistemaUsuarioPncveditalLote>();
        }

        public int CodigoSistemaUsuario { get; set; }
        public int? CodigoSistemaInstituicao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string MatriculaDnit { get; set; }
        public string Email { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool IndicadorAlterarSenha { get; set; }
        public bool IndicadorContaDesativada { get; set; }
        public bool IndicadorAgenteTransito { get; set; }
        public bool IndicadorUsuarioDnit { get; set; }
        public bool IndicadorEspecialistaBrlegal { get; set; }
        public string NumeroMatriculaSiape { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IndicadorMembroJari { get; set; }
        public DateTime DataUltimaAtividade { get; set; }
        public int PrazoInatividade { get; set; }
        public DateTime? DataVencimentoConta { get; set; }
        public bool IndicadorAgenteTransitoAnalistaRegistroInfracao { get; set; }
        public string PncvengenheiroCreanumero { get; set; }
        public int? CodigoUfpncvengenheiroCrea { get; set; }
        public int? PncvindicadorUsuarioDnit { get; set; }
        public int? PncvindicadorEngenheiro { get; set; }
        public int CodigoSistemaUsuarioPncvindicadorVinculo { get; set; }

        public virtual TblSistemaInstituicao CodigoSistemaInstituicaoNavigation { get; set; }
        public virtual TblSistemaUsuarioPncvindicadorVinculo CodigoSistemaUsuarioPncvindicadorVinculoNavigation { get; set; }
        public virtual TblBaseUf CodigoUfpncvengenheiroCreaNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoUsuarioAnaliseProcessualNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoUsuarioCadastroSapiensNavigation { get; set; }
        public virtual ICollection<TblCobrancaInfracao> TblCobrancaInfracaoCodigoUsuarioRevisaoProcessualNavigation { get; set; }
        public virtual ICollection<TblInfracaoDa> TblInfracaoDa { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorCondutor> TblInfracaoIdentificacaoInfratorCondutor { get; set; }
        public virtual ICollection<TblInfracaoIdentificacaoInfratorResponsavel> TblInfracaoIdentificacaoInfratorResponsavel { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoAnalise> TblInfracaoPreAutuacaoAnalise { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaDupla> TblInfracaoPreAutuacaoConferenciaDuplaCodigoSistemaUsuarioConferenciaDoisNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaDupla> TblInfracaoPreAutuacaoConferenciaDuplaCodigoSistemaUsuarioConferenciaRevisaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoConferenciaDupla> TblInfracaoPreAutuacaoConferenciaDuplaCodigoSistemaUsuarioConferenciaUmNavigation { get; set; }
        public virtual ICollection<TblInfracaoPreAutuacaoPreparacaoImagem> TblInfracaoPreAutuacaoPreparacaoImagem { get; set; }
        public virtual ICollection<TblInfracaoRecursoAnaliseJulgamentoJari> TblInfracaoRecursoAnaliseJulgamentoJari { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoSistemaUsuarioEmVistasNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoSistemaUsuarioInstrucaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoSistemaUsuarioRelatoNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecursoCodigoSistemaUsuarioRevisaoNavigation { get; set; }
        public virtual ICollection<TblInfracaoSolicitacaoAdvertencia> TblInfracaoSolicitacaoAdvertencia { get; set; }
        public virtual ICollection<TblJariintegrante> TblJariintegrante { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoColegiado> TblJarisessaoJulgamentoColegiado { get; set; }
        public virtual ICollection<TblJarisessaoJulgamentoVoto> TblJarisessaoJulgamentoVoto { get; set; }
        public virtual ICollection<TblPncvagenteTransitoCredenciamento> TblPncvagenteTransitoCredenciamento { get; set; }
        public virtual ICollection<TblPncvagenteTransitoSolicitacaoCredenciamento> TblPncvagenteTransitoSolicitacaoCredenciamento { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacaoCodigoSistemaUsuarioAnaliseNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoInstalacao> TblPncvestudoTecnicoInstalacaoCodigoSistemaUsuarioElaboracaoNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramentoCodigoSistemaUsuarioAnaliseNavigation { get; set; }
        public virtual ICollection<TblPncvestudoTecnicoMonitoramento> TblPncvestudoTecnicoMonitoramentoCodigoSistemaUsuarioElaboracaoNavigation { get; set; }
        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidadeCodigoSistemaUsuarioAnaliseNavigation { get; set; }
        public virtual ICollection<TblPncvestudoViabilidade> TblPncvestudoViabilidadeCodigoSistemaUsuarioElaboracaoNavigation { get; set; }
        public virtual ICollection<TblSistemaUsuarioAcao> TblSistemaUsuarioAcao { get; set; }
        public virtual ICollection<TblSistemaUsuarioBrlegalContrato> TblSistemaUsuarioBrlegalContrato { get; set; }
        public virtual ICollection<TblSistemaUsuarioEvento> TblSistemaUsuarioEvento { get; set; }
        public virtual ICollection<TblSistemaUsuarioFavorito> TblSistemaUsuarioFavorito { get; set; }
        public virtual ICollection<TblSistemaUsuarioMenu> TblSistemaUsuarioMenu { get; set; }
        public virtual ICollection<TblSistemaUsuarioPerfil> TblSistemaUsuarioPerfil { get; set; }
        public virtual ICollection<TblSistemaUsuarioPncvabrangencia> TblSistemaUsuarioPncvabrangencia { get; set; }
        public virtual ICollection<TblSistemaUsuarioPncveditalLote> TblSistemaUsuarioPncveditalLote { get; set; }
    }
}
