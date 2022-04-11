using FluentValidation;
using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Validacoes
{
    public class PaginasValidation : AbstractValidator<PaginasAcesso>
    {
        public PaginasValidation()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não encontrado.");
                    });

            RuleFor(c => c.NomeMenu)
                .NotEmpty().WithMessage("Nome do Menu é obrigatório.")
                .NotNull().WithMessage("Nome do Menu é obrigatório.");

            RuleFor(c => c.Controller)
                .NotEmpty().WithMessage("Controller é obrigatório.")
                .NotNull().WithMessage("Controller é obrigatório.");

            RuleFor(c => c.View)
                .NotEmpty().WithMessage("View é obrigatório.")
                .NotNull().WithMessage("View é obrigatório.");

            RuleFor(c => c.Desativado)
                .NotNull().WithMessage("Desativado/Ativado é obrigatório.");
        }
    }
}
