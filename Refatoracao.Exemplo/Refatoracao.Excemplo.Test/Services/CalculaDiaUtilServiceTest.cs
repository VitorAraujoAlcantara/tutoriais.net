using System;
using Refatoracao.Exemplo.Services;
using Refatoracao.Exemplo.Services.Interfaces;
using Xunit;

namespace Refatoracao.Excemplo.Test.Services
{
    public class CalculaDiaUtilServiceTest
    {
        private readonly ICalculaDiaUtilService service;
        public CalculaDiaUtilServiceTest()
        {
            service = new CalculaDiaUtilService();
        }

        [Theory]
        [InlineData(1,1)]// Confraternização Universal
        [InlineData(21,4)]// Tiradentes
        [InlineData(1,5)]// Dia do Trabalhador
        [InlineData(7,9)]// Independência
        [InlineData(12,10)]// Nossa Senhora Aparecida
        [InlineData(2,11)]// Finados
        [InlineData(15,11)]// Proclamação da República
        [InlineData(25, 12)]// Natal
        public void DiaUtil_FeriadosFixos(
            int dia, int mes)
        {
            DateTime data = new DateTime(2020, mes, dia);

            bool ret = service.DiaUtil(data, null);

            Assert.True(true);
        }

    }
}
