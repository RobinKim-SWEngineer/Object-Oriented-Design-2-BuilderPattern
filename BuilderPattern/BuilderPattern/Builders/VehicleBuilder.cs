namespace BuilderPattern
{
    public class VehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();

        public VehicleBuilder SetPrice(int price)
        {
            _vehicle.Price = price;
            return this;
        }

        public VehicleBuilder SetManufacturer(string manufacturer)
        {
            _vehicle.Manufacturer = manufacturer;
            return this;
        }

        public VehicleBuilder SetHorsePower(int horsePower)
        {
            _vehicle.HorsePower = horsePower;
            return this;
        }
        public VehicleBuilder SetModel(string model)
        {
            _vehicle.Model = model;
            return this;
        }
        public VehicleBuilder SetDoors(int doors)
        {
            _vehicle.Doors = doors;
            return this;
        }

        public VehicleBuilder SetColor(string color)
        {
            _vehicle.Color = color;
            return this;
        }

        private void Reset() => _vehicle = new Vehicle();

        public Vehicle Build()
        {
            Vehicle vehicle = _vehicle;
            Reset();

            return vehicle;
        }
    }
}
