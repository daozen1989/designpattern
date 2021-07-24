using System;
namespace FactoryMethod.API.BuilderPattern
{
    public class Car
    {
        public Car(string type, string color, int numberOfDoors, string city, string address)
        {
            Type = type;
            Color = color;
            NumberOfDoors = numberOfDoors;
            City = city;
            Address = address;
        }

        public string Type { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"CarType: {Type}, Color: {Color}, Number of doors: {NumberOfDoors}, Manufactured in {City}, at address: {Address}";
        }
    }
}
