using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoParametros
    {
        public int CodigoInfracaoParametros { get; set; }
        public int NotificacaoPrazoNasegunda { get; set; }
        public int NotificacaoPrazoNacarencia { get; set; }
        public int NotificacaoPrazoNpsegunda { get; set; }
        public int NotificacaoPrazoNpcarencia { get; set; }
        public int NotificacaoPrazoNdrecursoPrimeiraInstanciaSegunda { get; set; }
        public int NotificacaoPrazoEditalNa { get; set; }
        public int RemessaAtualNumero { get; set; }
        public int RemessaAtualAno { get; set; }
        public string NomeAutoridadeTransito { get; set; }
        public string PortariaAutoridadeTransito { get; set; }
        public string ConteudoEditalNa { get; set; }
        public string ConteudoEditalNp { get; set; }
        public string ExtratoPublicacaoNa { get; set; }
        public string ExtratoPublicacaoNp { get; set; }
        public int NotificacaoPrazoNaterca { get; set; }
        public int NotificacaoPrazoNaquarta { get; set; }
        public int NotificacaoPrazoNaquinta { get; set; }
        public int NotificacaoPrazoNasexta { get; set; }
        public int NotificacaoPrazoNpterca { get; set; }
        public int NotificacaoPrazoNpquarta { get; set; }
        public int NotificacaoPrazoNpquinta { get; set; }
        public int NotificacaoPrazoNpsexta { get; set; }
        public int NotificacaoPrazoNdrecursoPrimeiraInstanciaTerca { get; set; }
        public int NotificacaoPrazoNdrecursoPrimeiraInstanciaQuarta { get; set; }
        public int NotificacaoPrazoNdrecursoPrimeiraInstanciaQuinta { get; set; }
        public int NotificacaoPrazoNdrecursoPrimeiraInstanciaSexta { get; set; }
        public int NotificacaoPrazoEditalNp { get; set; }
        public int? CodigoSistemaCatalogoConexaoNotificacaoExpedicaoProcessamento { get; set; }
        public int? CodigoSistemaCatalogoConexaoNotificacaoExpedicaoInterface { get; set; }
        public int? CodigoSistemaCatalogoConexaoNotificacaoSegundaViaProcessamento { get; set; }
        public int? CodigoSistemaCatalogoConexaoNotificacaoSegundaViaInterface { get; set; }
        public int? CodigoSistemaCatalogoConexaoNotificacaoAutuacaoSegundaViaRepositorio { get; set; }
        public int? CodigoSistemaCatalogoConexaoNotificacaoPenalidadeSegundaViaRepositorio { get; set; }
        public int? CodigoSistemaCatalogoConexaoNotificacaoDecisaoSegundaViaRepositorio { get; set; }
        public string ExtratoPublicacaoNdrecursoPrimeiraInstancia { get; set; }
        public string ConteudoEditalNdrecursoPrimeiraInstancia { get; set; }
        public int NotificacaoPrazoEditalNdrecursoPrimeiraInstancia { get; set; }
        public int NotificacaoPrazoNdrecursoSegundaInstanciaSegunda { get; set; }
        public int NotificacaoPrazoNdrecursoSegundaInstanciaTerca { get; set; }
        public int NotificacaoPrazoNdrecursoSegundaInstanciaQuarta { get; set; }
        public int NotificacaoPrazoNdrecursoSegundaInstanciaQuinta { get; set; }
        public int NotificacaoPrazoNdrecursoSegundaInstanciaSexta { get; set; }
        public string ConteudoEditalNdrecursoSegundaInstancia { get; set; }
        public int NotificacaoPrazoEditalNdrecursoSegundaInstancia { get; set; }
        public string ExtratoPublicacaoNdrecursoSegundaInstancia { get; set; }

        public virtual TblSistemaCatalogoConexao CodigoSistemaCatalogoConexaoNotificacaoAutuacaoSegundaViaRepositorioNavigation { get; set; }
        public virtual TblSistemaCatalogoConexao CodigoSistemaCatalogoConexaoNotificacaoDecisaoSegundaViaRepositorioNavigation { get; set; }
        public virtual TblSistemaCatalogoConexao CodigoSistemaCatalogoConexaoNotificacaoExpedicaoInterfaceNavigation { get; set; }
        public virtual TblSistemaCatalogoConexao CodigoSistemaCatalogoConexaoNotificacaoExpedicaoProcessamentoNavigation { get; set; }
        public virtual TblSistemaCatalogoConexao CodigoSistemaCatalogoConexaoNotificacaoPenalidadeSegundaViaRepositorioNavigation { get; set; }
        public virtual TblSistemaCatalogoConexao CodigoSistemaCatalogoConexaoNotificacaoSegundaViaInterfaceNavigation { get; set; }
        public virtual TblSistemaCatalogoConexao CodigoSistemaCatalogoConexaoNotificacaoSegundaViaProcessamentoNavigation { get; set; }
    }
}
