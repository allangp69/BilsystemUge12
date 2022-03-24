namespace BilsystemUge12;

public class Consumption
{
    private readonly int numberOfKilometersDriven;
    private readonly int litersOfFuel;

    public Consumption(int numberOfKilometersDriven, int litersOfFuel)
    {
        this.numberOfKilometersDriven = numberOfKilometersDriven;
        this.litersOfFuel = litersOfFuel;
    }

    public int GetNumberOfKilometersDriven()
    {
        return numberOfKilometersDriven;
    }
    
    public int GetLitersOfFuel()
    {
        return litersOfFuel;
    }
}