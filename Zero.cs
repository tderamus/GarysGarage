namespace Garage;

public class Zero : Vehicle
{
    public double BatteryKWh { get; set; }
    
    public void ChargeBattery()
    {
        Console.WriteLine($"This Ram's color is {MainColor}, and can hold {MaximumOccupancy} passengers.");
    }
}