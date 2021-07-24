using System;
using FactoryMethod.API.Services.Factories.abstracts;
using FactoryMethod.API.Services.Implementations;
using FactoryMethod.API.Services.Interfaces;

namespace FactoryMethod.API.Services.Factories
{
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create()
        {
            return new CoolingManager();
        }
    }
}
