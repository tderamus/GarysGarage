namespace Garage;

public class Ram : Vehicle
{
    public double FuelCapacity { get; set; }
   
    public void RefuelTank()
    {
        Console.WriteLine($"This {Model}'s color is {MainColor}, and can hold {MaximumOccupancy} passengers.");
    }

    public override void Drive()
    {
        Console.WriteLine("ZoomZoomZoooommmmm!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {Model} pickup truck carefully turns {direction}");
    }
}