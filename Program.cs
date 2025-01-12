using Garage;

Zero fxs = new Zero {Model = "Exciting", MainColor = "Green", MaximumOccupancy = 6, BatteryKWh = 64.89};
Tesla modelS = new Tesla { Model = "Model s", MainColor = "black", MaximumOccupancy = 4, BatteryKWh = 44.99 };
Tesla modelX = new Tesla { Model = "Model X", MainColor = "blue", MaximumOccupancy = 4, BatteryKWh = 64.99 };
Cessna mx410 = new Cessna { Model = "Windwurl", MaximumOccupancy = 12, MainColor = "Yellow", FuelCapacity = 89.5};
Ram ram = new Ram {Model = "Dodge", FuelCapacity = 32.9, MaximumOccupancy = 5, MainColor = "Red"};

mx410.RefuelTank();
mx410.Drive();