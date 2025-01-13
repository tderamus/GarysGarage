namespace Garage;

public class Tesla : Vehicle 
{
    public double BatteryKWh { get; set; }
   
    public void ChargeBattery()
    {
        Console.WriteLine(@$"This {Model}'s color is {MainColor}, and can hold {MaximumOccupancy} passengers.
        It has an amazing battery capacity of {BatteryKWh}");
    }

    public override void Drive()
    {
        Console.WriteLine("SeeeYaaaaaaa!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {Model} Coupe carefully turns {direction}");
    }
}