using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvnotaInstalacao
    {
        public TblPncvnotaInstalacao()
        {
            TblPncvnotaInstalacaoEquipamento = new HashSet<TblPncvnotaInstalacaoEquipamento>();
        }

        public int CodigoPncvnotaInstalacao { get; set; }
        public int? CodigoPncveditalLote { get; set; }
        public int Numero { get; set; }
        public short Ano { get; set; }
        public DateTime? DataEmissao { get; set; }
        public string ArquivoReferenciaNome { get; set; }
        public string ArquivoReferenciaNomeFisico { get; set; }
        public int? ArquivoReferenciaTamanho { get; set; }

        public virtual TblPncveditalLote CodigoPncveditalLoteNavigation { get; set; }
        public virtual ICollection<TblPncvnotaInstalacaoEquipamento> TblPncvnotaInstalacaoEquipamento { get; set; }
    }
}
