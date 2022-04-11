using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblPncvautorizacaoInstalacaoEquipamentoSituacao
    {
        public TblPncvautorizacaoInstalacaoEquipamentoSituacao()
        {
            TblPncvautorizacaoInstalacaoEquipamento = new HashSet<TblPncvautorizacaoInstalacaoEquipamento>();
            TblPncvautorizacaoInstalacaoEquipamentoEvento = new HashSet<TblPncvautorizacaoInstalacaoEquipamentoEvento>();
        }

        public int CodigoPncvautorizacaoInstalacaoEquipamentoSituacao { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamento> TblPncvautorizacaoInstalacaoEquipamento { get; set; }
        public virtual ICollection<TblPncvautorizacaoInstalacaoEquipamentoEvento> TblPncvautorizacaoInstalacaoEquipamentoEvento { get; set; }
    }
}
