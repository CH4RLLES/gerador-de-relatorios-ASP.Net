﻿using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblPncvequipamentoCodigo
    {
        public int CodigoPncvequipamentoCodigo { get; set; }
        public string CodigoEquipamento { get; set; }
        public string SiglaUf { get; set; }
        public string TipoEquipamento { get; set; }
        public int Ocorrencia { get; set; }
    }
}
