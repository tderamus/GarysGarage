namespace Garage;

public class Ram : Vehicle
{
    public double FuelCapacity { get; set; }
   
    public void RefuelTank()
    {
        Console.WriteLine($"This {Model}'s color is {MainColor}, and can hold {MaximumOccupancy} passengers.");
    }
}