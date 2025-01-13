namespace Garage;

public class Zero : Vehicle
{
    public double BatteryKWh { get; set; }
    
    public void ChargeBattery()
    {
        Console.WriteLine($"This {Model}'s color is {MainColor}, and can hold {MaximumOccupancy} passengers.");
    }

    public override void Drive()
    {
        Console.WriteLine("WhoootHooooo!");
    }
}