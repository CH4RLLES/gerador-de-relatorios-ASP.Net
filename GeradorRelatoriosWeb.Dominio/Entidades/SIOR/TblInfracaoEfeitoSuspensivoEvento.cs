using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoEfeitoSuspensivoEvento
    {
        public long CodigoInfracaoEfeitoSuspensivoEvento { get; set; }
        public long CodigoInfracaoEfeitoSuspensivo { get; set; }
        public int CodigoInfracaoEfeitoSuspensivoSituacao { get; set; }
        public int CodigoInfracaoEfeitoSuspensivoFase { get; set; }
        public DateTime Data { get; set; }
        public string Identificacao { get; set; }
        public string Descricao { get; set; }
        public string NomeSistemaUsuario { get; set; }

        public virtual TblInfracaoEfeitoSuspensivoFase CodigoInfracaoEfeitoSuspensivoFaseNavigation { get; set; }
        public virtual TblInfracaoEfeitoSuspensivo CodigoInfracaoEfeitoSuspensivoNavigation { get; set; }
        public virtual TblInfracaoEfeitoSuspensivoSituacao CodigoInfracaoEfeitoSuspensivoSituacaoNavigation { get; set; }
    }
}
