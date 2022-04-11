using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.PNCV_168
{
    public partial class TblRegistroTesteEquipamento
    {
        public long CodigoRegistroTesteEquipamento { get; set; }
        public long CodigoRemessaDados { get; set; }
        public string Nome { get; set; }
        public string NomeFisico { get; set; }
        public int Tamanho { get; set; }
        public DateTime DataHora { get; set; }
        public byte Hora { get; set; }
        public int? SequenciaImagem { get; set; }

        public virtual TblRemessaDados CodigoRemessaDadosNavigation { get; set; }
    }
}
