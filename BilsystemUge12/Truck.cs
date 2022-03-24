namespace BilsystemUge12;

public class Truck
    : Car
{
    private readonly int loadCapacity;

    public Truck(string registrationNumber, int loadCapacity)
        :base(registrationNumber)
    {
        this.loadCapacity = loadCapacity;
    }

    public int GetLoadCapacity()
    {
        return loadCapacity;
    }
}