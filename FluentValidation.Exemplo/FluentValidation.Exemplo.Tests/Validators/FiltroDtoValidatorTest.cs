using System;
using FluentValidation.Exemplo.Models.Dtos;
using FluentValidation.Exemplo.Validators;
using Xunit;

namespace FluentValidation.Exemplo.Tests.Validators
{
    public class FiltroDtoValidatorTest
    {
        private readonly AbstractValidator<FiltrosDto> validator;
        private readonly FiltrosDto filtro;
        public FiltroDtoValidatorTest()
        {
            validator = new FiltroDtoValidator();
            filtro = new FiltrosDto()
            {
                Nome = "Nome qualquer",
                DataInicial = DateTime.Now.AddDays(-30),
                DataFinal = DateTime.Now,
                Codigo = "1234567890123"
            };
        }

        [Fact]
        public void Validate_TesteDeControle()
        {
            var result = validator.Validate(filtro);
            Assert.True(result.IsValid);
        }

        [Fact]
        public void Validate_NomeMaiorQueQuatroCaracteres()
        {
            filtro.Nome = "123";
            var result = validator.Validate(filtro);
            Assert.False(result.IsValid);
        }

        [Fact]
        public void Validate_NomeMenorQueCinquentaCaracteres()
        {
            filtro.Nome = "123456789012345678901234567890123456789012345678901";
            var result = validator.Validate(filtro);
            Assert.False(result.IsValid);
        }

        [Fact]
        public void Validate_DataInicialMenorQueDataFinal()
        {
            filtro.DataInicial = DateTime.Now;
            filtro.DataFinal = filtro.DataInicial.AddDays(-1);
            var result = validator.Validate(filtro);
            Assert.False(result.IsValid);
        }

        [Fact]
        public void Validate_CodigoIgualA13Digitos()
        {
            filtro.Codigo = "123456789012";
            var result = validator.Validate(filtro);
            Assert.False(result.IsValid);
        }


    }
}
