using System;
namespace FactoryMethod.API.Services.Interfaces
{
    public interface IAirConditioner
    {
        string Operate(string temperature);
    }
}
