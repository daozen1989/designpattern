using System;
namespace FactoryMethod.API.BuilderPattern
{
    public class CarBuilder : ICarBuilder
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public CarBuilder SetAddress(string address)
        {
            Address = address;
            return this;
        }

        public CarBuilder SetCity(string city)
        {
            City = city;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }

        public CarBuilder SetNumberOfDoors(int numberOfDoors)
        {
            NumberOfDoors = numberOfDoors;
            return this;
        }

        public CarBuilder SetType(string type)
        {
            Type = type;
            return this;
        }

        public Car Build()
        {
            return new Car(Type, Color, NumberOfDoors, City, Address);
        }
    }
}
