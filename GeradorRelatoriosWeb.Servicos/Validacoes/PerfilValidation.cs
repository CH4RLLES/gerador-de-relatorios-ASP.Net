using FluentValidation;
using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Validacoes
{
    public class PerfilValidation : AbstractValidator<PerfilAcesso>
    {
        public PerfilValidation()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não encontrado.");
                    });

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório.")
                .NotNull().WithMessage("Nome é obrigatório.");

        }
    }
}
