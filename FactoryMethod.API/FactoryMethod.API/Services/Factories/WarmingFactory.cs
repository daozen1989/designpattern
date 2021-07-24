using System;
using FactoryMethod.API.Services.Factories.abstracts;
using FactoryMethod.API.Services.Implementations;
using FactoryMethod.API.Services.Interfaces;

namespace FactoryMethod.API.Services.Factories
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create() => new WarmingManager();
    }
}
