using System;
using FactoryMethod.API.Services.Interfaces;

namespace FactoryMethod.API.Services.Factories.abstracts
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create();
    }
}
