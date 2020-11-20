using System;
using FluentValidation.Exemplo.Models.Dtos;

namespace FluentValidation.Exemplo.Validators
{
    public class FiltroDtoValidator: AbstractValidator<FiltrosDto>
    {

        public FiltroDtoValidator()
        {
            ValidatorOptions.LanguageManager.Culture = new System.Globalization.CultureInfo("pt-BR");

            RuleFor(x => x.Nome)
                .MinimumLength(4)
                .MaximumLength(50);

            RuleFor(x => x.DataInicial)
                .LessThanOrEqualTo(x => x.DataFinal);

            RuleFor(x => x.Codigo)
                .Length(13);
        }
    }
}
