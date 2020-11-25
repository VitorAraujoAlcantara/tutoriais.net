using System;
namespace Refatoracao.Exemplo.Services.Interfaces
{
    public interface ICalculaDiaUtilService
    {
        bool DiaUtil(DateTime data, DateTime[] feiradosMoveis);
    }
}
