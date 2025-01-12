namespace Garage;

public class Tesla : Vehicle 
{
    public double BatteryKWh { get; set; }
   
    public void ChargeBattery()
    {
        Console.WriteLine(@$"This {Model}'s color is {MainColor}, and can hold {MaximumOccupancy} passengers.
        It has an amazing battery capacity of {BatteryKWh}");
    }
}