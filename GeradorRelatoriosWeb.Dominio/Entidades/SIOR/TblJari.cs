using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblJari
    {
        public TblJari()
        {
            TblInfracaoRecurso = new HashSet<TblInfracaoRecurso>();
            TblJariarquivo = new HashSet<TblJariarquivo>();
            TblJariintegrante = new HashSet<TblJariintegrante>();
            TblJarisessaoJulgamento = new HashSet<TblJarisessaoJulgamento>();
        }

        public int CodigoJari { get; set; }
        public int CodigoBaseUf { get; set; }
        public int? CodigoRenavammunicipio { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string EnderecoLogradouro { get; set; }
        public string EnderecoNumeroImovel { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoCep { get; set; }
        public string MandatoPortaria { get; set; }
        public DateTime? MandatoDataInicio { get; set; }
        public DateTime? MandatoDataTermino { get; set; }
        public bool IndicadorDesativada { get; set; }
        public bool IndicadorRecursoIntempestivo { get; set; }

        public virtual TblBaseUf CodigoBaseUfNavigation { get; set; }
        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecurso { get; set; }
        public virtual ICollection<TblJariarquivo> TblJariarquivo { get; set; }
        public virtual ICollection<TblJariintegrante> TblJariintegrante { get; set; }
        public virtual ICollection<TblJarisessaoJulgamento> TblJarisessaoJulgamento { get; set; }
    }
}
