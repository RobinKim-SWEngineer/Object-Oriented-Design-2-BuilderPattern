# Object-Oriented-Design-2-BuilderPattern
Pattern says : "Let me handle the complex constriction part separately"

Builder pattern **seperates** the process of complex constriction of an object. It makes the **code readable** especially when object has lots of properties to be specified.

This pattern would not be neccessary unless the amount of properties is many. The initialization of the object is much more readable and **explicit** than using class constructor. The order of each setting does not matter.

```
    VehicleBuilder vehicleBuilder = new VehicleBuilder();
    
    Vehicle hyundaiCar = vehicleBuilder.SetDoors(4)
                                       .SetColor("Red")
                                       .SetManufacturer("Hyundai")
                                       .SetModel("I30")
                                       .SetPrice(450000)
                                       .SetHorsePower(650)
                                       .Build();
```

In the object builder ( in this example, VehicleBuilder class ) needs to be *Reset process* that **reinitializes** the object so the builder can be used again for another object creation. This would be called inside Build(), which is the moment of forwarding the final result of object building steps.  
```
    private void Reset() => _vehicle = new Vehicle();
    
    public Vehicle Build()
        {
            Vehicle vehicle = _vehicle;
            Reset();

            return vehicle;
        }
```

