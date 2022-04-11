using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoFinanceiroPagamentoBaixaManualArquivo
    {
        public long CodigoInfracaoFinanceiroPagamentoBaixaManualArquivo { get; set; }
        public long CodigoInfracaoFinanceiroPagamentoBaixaManual { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public int Tamanho { get; set; }
        public string NomeFisico { get; set; }
        public DateTime DataCriacao { get; set; }

        public virtual TblInfracaoFinanceiroPagamentoBaixaManual CodigoInfracaoFinanceiroPagamentoBaixaManualNavigation { get; set; }
    }
}
