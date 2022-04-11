using FluentValidation;
using GeradorRelatoriosWeb.Dominio.Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorRelatoriosWeb.Servicos.Validacoes
{
    public class UsuarioValidation : AbstractValidator<Usuario>
    {
        public UsuarioValidation()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não encontrado.");
                    });

            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("CPF é obrigatório.")
                .NotNull().WithMessage("CPF é obrigatório.");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório.")
                .NotNull().WithMessage("Nome é obrigatório.");

            RuleFor(c => c.Token)
                .NotEmpty().WithMessage("Token é obrigatório.")
                .NotNull().WithMessage("Token é obrigatório.");
        }
    }
}
