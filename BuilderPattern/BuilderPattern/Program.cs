namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder vehicleBuilder = new VehicleBuilder();

            Vehicle hyundaiCar = vehicleBuilder.SetDoors(4)
                                               .SetColor("Red")
                                               .SetManufacturer("Hyundai")
                                               .SetModel("I30")
                                               .SetPrice(450000)
                                               .SetHorsePower(650)
                                               .Build();

            Vehicle skodaCar = vehicleBuilder.SetDoors(4)
                                             .SetColor("Blue")
                                             .SetManufacturer("Skoda")
                                             .SetModel("Kodiaq")
                                             .SetPrice(750000)
                                             .SetHorsePower(800)
                                             .Build();

            Vehicle toyotaCar = vehicleBuilder.SetDoors(3)
                                              .SetColor("Purple")
                                              .SetManufacturer("Totyta")
                                              .SetModel("CV3")
                                              .SetPrice(650000)
                                              .SetHorsePower(1200)
                                              .Build();


            System.Console.WriteLine(hyundaiCar.ToString());

            System.Console.WriteLine(skodaCar.ToString());

            System.Console.WriteLine(toyotaCar.ToString());

            System.Console.ReadKey();
        }
    }
}
