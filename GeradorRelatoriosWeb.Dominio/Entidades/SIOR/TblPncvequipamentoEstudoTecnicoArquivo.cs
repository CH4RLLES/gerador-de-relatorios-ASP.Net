using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoEstudoTecnicoArquivo
    {
        public int CodigoPncvequipamentoEstudoTecnicoArquivo { get; set; }
        public int CodigoPncvequipamentoEstudoTecnico { get; set; }
        public string ArquivoReferenciaNome { get; set; }
        public string ArquivoReferenciaNomeFisico { get; set; }
        public int ArquivoReferenciaTamanho { get; set; }
        public string Descricao { get; set; }

        public virtual TblPncvequipamentoEstudoTecnico CodigoPncvequipamentoEstudoTecnicoNavigation { get; set; }
    }
}
