using System;
using System.Collections.Generic;

namespace GeradorRelatorios
{
    public partial class TblSistemaConfiguracao
    {
        public int CodigoSistemaConfiguracao { get; set; }
        public int CodigoSistemaConfiguracaoPropriedadeTipo { get; set; }
        public string NomePropriedade { get; set; }
        public string ValorPropriedade { get; set; }

        public virtual TblSistemaConfiguracaoPropriedadeTipo CodigoSistemaConfiguracaoPropriedadeTipoNavigation { get; set; }
    }
}
