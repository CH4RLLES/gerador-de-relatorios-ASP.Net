﻿using System;
using System.Collections.Generic;

namespace GeradorRelatoriosWeb.Dominio.Entidades.SIOR
{
    public partial class TblInfracaoRecursoIndicadorRecorrente
    {
        public TblInfracaoRecursoIndicadorRecorrente()
        {
            TblInfracaoRecurso = new HashSet<TblInfracaoRecurso>();
        }

        public int CodigoInfracaoRecursoIndicadorRecorrente { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<TblInfracaoRecurso> TblInfracaoRecurso { get; set; }
    }
}
