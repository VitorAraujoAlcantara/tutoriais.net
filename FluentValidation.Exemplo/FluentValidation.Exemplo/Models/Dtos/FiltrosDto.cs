using System;
namespace FluentValidation.Exemplo.Models.Dtos
{
    public class FiltrosDto
    {
        public string Nome { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string Codigo { get; set; }
    }
}
