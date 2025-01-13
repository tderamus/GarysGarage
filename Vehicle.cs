namespace Garage;

public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }
    public required string Model { get; set; }
    public virtual void Drive()
    {
        Console.WriteLine("VROOOOOOMMMMM!");
    }
    public virtual void Turn(string direction)
    {
        Console.WriteLine($"The vehicle {Model} carefully turns {direction}");
    }
    public virtual void Stop()
    {
        Console.WriteLine($"The vehicle {Model} gently rolls to a stop.");
    }
}
