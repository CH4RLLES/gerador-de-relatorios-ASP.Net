using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_LIC_4
{
    public partial class AuxRemessaDadosRepetidaRegistroTesteEquipamento
    {
        public long CodigoRegistroTesteEquipamento { get; set; }
        public long CodigoRemessaDados { get; set; }
        public DateTime DataHora { get; set; }
        public string ImagemNome { get; set; }
        public string ImagemSequencia { get; set; }
        public string ImagemCometimentoNomeFisico { get; set; }
        public bool? IndicadorImagemExcluida { get; set; }
    }
}
