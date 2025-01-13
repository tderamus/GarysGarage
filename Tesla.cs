namespace Garage;

public class Tesla : Vehicle 
{
    public double BatteryKWh { get; set; }
   
    public void ChargeBattery()
    {
        Console.WriteLine(@$"This {Model}'s color is {MainColor}, and can hold {MaximumOccupancy} passengers.
        It has an amazing battery capacity of {BatteryKWh}");
        Drive();
        Turn("left");
        Stop();
    }

    public override void Drive()
    {
        Console.WriteLine($"The {Model} is quiet, but when driving is sounds like.......SeeeYaaaaaaa!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {Model} Coupe carefully turns {direction}");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {Model} Coupe rolls to a quick quiet start stop.");
    }
}