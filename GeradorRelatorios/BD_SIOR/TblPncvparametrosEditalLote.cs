using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvparametrosEditalLote
    {
        public int CodigoPncvparametrosEditalLote { get; set; }
        public int CodigoPncvparametros { get; set; }
        public int CodigoPncveditalLote { get; set; }
        public bool IndicadorProcessamentoRemessaAtivado { get; set; }
        public bool IndicadorCadastroInfracaoAtivado { get; set; }
        public int PrazoEnvioContagem { get; set; }
        public int PrazoEnvioInfracao { get; set; }
        public string ServidorSftpUsuarioNome { get; set; }
        public string ServidorSftpUsuarioSenha { get; set; }
        public string ServidorSftpCaminhoRemessaContagem { get; set; }
        public string ServidorSftpCaminhoRetornoContagem { get; set; }
        public string ServidorSftpCaminhoRemessaInfracao { get; set; }
        public string ServidorSftpCaminhoRetornoInfracao { get; set; }
        public string CaminhoRemessaContagem { get; set; }
        public string CaminhoProcessamentoRemessaContagem { get; set; }
        public string CaminhoRetornoContagem { get; set; }
        public string CaminhoRemessaInfracao { get; set; }
        public string CaminhoProcessamentoRemessaInfracao { get; set; }
        public string CaminhoRetornoInfracao { get; set; }
        public string ServidorSftpCaminhoRemessaProcessamentoInfracao { get; set; }
        public string ServidorSftpCaminhoRemessaProcessamentoContagem { get; set; }

        public virtual TblPncveditalLote CodigoPncveditalLoteNavigation { get; set; }
        public virtual TblPncvparametros CodigoPncvparametrosNavigation { get; set; }
    }
}
