using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvequipamentoEstudoTecnico
    {
        public TblPncvequipamentoEstudoTecnico()
        {
            TblPncvequipamentoEstudoTecnicoArquivo = new HashSet<TblPncvequipamentoEstudoTecnicoArquivo>();
            TblPncvequipamentoEstudoTecnicoFaixa = new HashSet<TblPncvequipamentoEstudoTecnicoFaixa>();
        }

        public int CodigoPncvequipamentoEstudoTecnico { get; set; }
        public int CodigoPncvequipamento { get; set; }
        public DateTime Data { get; set; }
        public int? CodigoPncvestudoTecnicoInstalacao { get; set; }
        public int? CodigoPncvequipamentoIndicadorComunicacao { get; set; }

        public virtual TblPncvequipamentoIndicadorComunicacao CodigoPncvequipamentoIndicadorComunicacaoNavigation { get; set; }
        public virtual TblPncvequipamento CodigoPncvequipamentoNavigation { get; set; }
        public virtual TblPncvestudoTecnicoInstalacao CodigoPncvestudoTecnicoInstalacaoNavigation { get; set; }
        public virtual ICollection<TblPncvequipamentoEstudoTecnicoArquivo> TblPncvequipamentoEstudoTecnicoArquivo { get; set; }
        public virtual ICollection<TblPncvequipamentoEstudoTecnicoFaixa> TblPncvequipamentoEstudoTecnicoFaixa { get; set; }
    }
}
