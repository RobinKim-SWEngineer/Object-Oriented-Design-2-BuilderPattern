using System;

namespace BuilderPattern
{
    public class Vehicle
    {
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public int HorsePower { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public override string ToString() => $"Car information -- Price : {Price}, Manufacturer : {Manufacturer}, HorsePower : {HorsePower}, Model : {Model}, Color : {Color}, Doors : {Doors} {Environment.NewLine}";
        public void Drive() => System.Console.WriteLine("Boo!!!!");
        public void Stop() => System.Console.WriteLine("Stopped!!!");
    }
}
