namespace BilsystemUge12;

public abstract class Car
{
    protected string registrationNumber;
    private List<Consumption> _consumptionList;

    public Car(string registrationNumber)
    {
        this.registrationNumber = registrationNumber;
        _consumptionList = new List<Consumption>();
    }

    public string GetRegistrationNumber()
    {
        return this.registrationNumber;
    }

    public double CalculateAverageConsumptionKmPerLiter()
    {
        if (_consumptionList is null || !(_consumptionList.Any()))
        {
            return 0;
        }
        
        return _consumptionList.Where(c => c.GetLitersOfFuel() > 0).Average(c => c.GetNumberOfKilometersDriven() / c.GetLitersOfFuel());
    }

    public void CreateConsumption(int numberOfKilometersDriven, int litersOfFuel)
    {
        this._consumptionList.Add(new Consumption(numberOfKilometersDriven, litersOfFuel));
    }
}