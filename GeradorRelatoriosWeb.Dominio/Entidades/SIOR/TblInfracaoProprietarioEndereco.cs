using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoProprietarioEndereco
    {
        public long CodigoInfracaoProprietarioEndereco { get; set; }
        public long CodigoInfracaoProprietario { get; set; }
        public int? CodigoUf { get; set; }
        public int? CodigoRenavammunicipio { get; set; }
        public string Logradouro { get; set; }
        public string NumeroImovel { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string NumeroCep { get; set; }
        public bool IndicadorAtivo { get; set; }
        public DateTime? DataValidade { get; set; }

        public virtual TblInfracaoProprietario CodigoInfracaoProprietarioNavigation { get; set; }
        public virtual TblBaseUf CodigoUfNavigation { get; set; }
    }
}
