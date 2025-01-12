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

}