using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblBrlegalEmpresa
    {
        public TblBrlegalEmpresa()
        {
            TblBrlegalContrato = new HashSet<TblBrlegalContrato>();
        }

        public int CodigoBrlegalEmpresa { get; set; }
        public int? CodigoBaseUf { get; set; }
        public int? CodigoBaseMunicipio { get; set; }
        public string NomeEmpresa { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Informacao { get; set; }
        public string Representante { get; set; }
        public string Cnpj { get; set; }

        public virtual TblBaseMunicipio CodigoBaseMunicipioNavigation { get; set; }
        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual ICollection<TblBrlegalContrato> TblBrlegalContrato { get; set; }
    }
}
