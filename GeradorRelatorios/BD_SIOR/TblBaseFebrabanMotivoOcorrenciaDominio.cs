using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblBaseFebrabanMotivoOcorrenciaDominio
    {
        public TblBaseFebrabanMotivoOcorrenciaDominio()
        {
            TblBaseFebrabanMotivoOcorrencia = new HashSet<TblBaseFebrabanMotivoOcorrencia>();
        }

        public int CodigoBaseFebrabanMotivoOcorrenciaDominio { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TblBaseFebrabanMotivoOcorrencia> TblBaseFebrabanMotivoOcorrencia { get; set; }
    }
}
