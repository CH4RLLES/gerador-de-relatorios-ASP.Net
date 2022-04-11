using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaCatalogoConexao
    {
        public TblSistemaCatalogoConexao()
        {
            TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoAutuacaoSegundaViaRepositorioNavigation = new HashSet<TblInfracaoParametros>();
            TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoDecisaoSegundaViaRepositorioNavigation = new HashSet<TblInfracaoParametros>();
            TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoExpedicaoInterfaceNavigation = new HashSet<TblInfracaoParametros>();
            TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoExpedicaoProcessamentoNavigation = new HashSet<TblInfracaoParametros>();
            TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoPenalidadeSegundaViaRepositorioNavigation = new HashSet<TblInfracaoParametros>();
            TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoSegundaViaInterfaceNavigation = new HashSet<TblInfracaoParametros>();
            TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoSegundaViaProcessamentoNavigation = new HashSet<TblInfracaoParametros>();
        }

        public int CodigoSistemaCatalogoConexao { get; set; }
        public int CodigoSistemaCatalogoConexaoServico { get; set; }
        public string Nome { get; set; }
        public string CodigoIdentificacao { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public int? Porta { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string PastaRemotaPadrao { get; set; }
        public string PastaRemotaTemporariaPadrao { get; set; }
        public string PastaLocalPadrao { get; set; }
        public string CertificadoAplicacaoEnderecoArquivo { get; set; }
        public string CertificadoAplicacaoSenha { get; set; }

        public virtual TblSistemaCatalogoConexaoServico CodigoSistemaCatalogoConexaoServicoNavigation { get; set; }
        public virtual ICollection<TblInfracaoParametros> TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoAutuacaoSegundaViaRepositorioNavigation { get; set; }
        public virtual ICollection<TblInfracaoParametros> TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoDecisaoSegundaViaRepositorioNavigation { get; set; }
        public virtual ICollection<TblInfracaoParametros> TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoExpedicaoInterfaceNavigation { get; set; }
        public virtual ICollection<TblInfracaoParametros> TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoExpedicaoProcessamentoNavigation { get; set; }
        public virtual ICollection<TblInfracaoParametros> TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoPenalidadeSegundaViaRepositorioNavigation { get; set; }
        public virtual ICollection<TblInfracaoParametros> TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoSegundaViaInterfaceNavigation { get; set; }
        public virtual ICollection<TblInfracaoParametros> TblInfracaoParametrosCodigoSistemaCatalogoConexaoNotificacaoSegundaViaProcessamentoNavigation { get; set; }
    }
}
