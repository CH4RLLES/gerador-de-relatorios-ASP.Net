using FluentValidation;
using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Validacoes
{
    public class PerfilPaginasValidation : AbstractValidator<PerfilPaginas>
    {
        public PerfilPaginasValidation()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não encontrado.");
                    });

        }
    }
}

