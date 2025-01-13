namespace Garage;

public class Zero : Vehicle
{
    public double BatteryKWh { get; set; }
    
    public void ChargeBattery()

    {
        Console.WriteLine($"This {Model}'s color is {MainColor}, and can hold {MaximumOccupancy} passengers.");
        Drive();
        Turn("left");
        Stop();
    }

    public override void Drive()
    {
        Console.WriteLine($"When this {Model} is driving it sounds like WoootHoooo!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {Model} carefully turns {direction}");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {Model} rolls to a really exciting hard stop.");
    }
}