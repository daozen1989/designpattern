using System;
using FactoryMethod.API.Services.Interfaces;

namespace FactoryMethod.API.Services.Implementations
{
    public class CoolingManager : IAirConditioner
    {
        public string Operate(string temperature)
        {
            return $"Cooling the room to the required temperature of {temperature} degrees";
        }
    }
}
