using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblSistemaConfiguracaoPropriedadeTipo
    {
        public TblSistemaConfiguracaoPropriedadeTipo()
        {
            TblSistemaConfiguracao = new HashSet<TblSistemaConfiguracao>();
        }

        public int CodigoSistemaConfiguracaoPropriedadeTipo { get; set; }
        public string Nome { get; set; }
        public int Codigo { get; set; }

        public virtual ICollection<TblSistemaConfiguracao> TblSistemaConfiguracao { get; set; }
    }
}
