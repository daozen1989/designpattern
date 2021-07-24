using System;
using FactoryMethod.API.Services.Interfaces;

namespace FactoryMethod.API.Services.Implementations
{
    public class WarmingManager : IAirConditioner
    {
        public string Operate(string temperature)
        {
            return $"Warming the room to the required temperature of {temperature} degrees.";
        }
    }
}
