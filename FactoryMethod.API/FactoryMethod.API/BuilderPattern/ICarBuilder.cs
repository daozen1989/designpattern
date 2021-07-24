using System;
namespace FactoryMethod.API.BuilderPattern
{
    public interface ICarBuilder
    {
        CarBuilder SetType(string type);
        CarBuilder SetColor(string color);
        CarBuilder SetNumberOfDoors(int numberOfDoors);
        CarBuilder SetCity(string city);
        CarBuilder SetAddress(string address);
        Car Build();
    }
}
