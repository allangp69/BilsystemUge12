namespace BilsystemUge12;

public class CarSystem
{
    private List<Car> Cars { get; }
    
    public CarSystem()
    {
        Cars = new List<Car>();
    }

    public string FindMostEconimicCar()
    {
        var mostEconomicCar = Cars.OrderByDescending(c => c.CalculateAverageConsumptionKmPerLiter()).FirstOrDefault();
        return mostEconomicCar is null ? "No cars found" : mostEconomicCar.GetRegistrationNumber();
    }

    public int CalculateTotalLoadCapacity()
    {
        return Cars.OfType<Truck>().Sum(c => c.GetLoadCapacity());
    }

    public void CreatePassengerCar(string registrationNumber, int numberOfSeats)
    {
        this.Cars.Add(new PassengerCar(registrationNumber, numberOfSeats));
    }

    public void CreateTruck(string registrationNumber, int loadCapacity)
    {
        this.Cars.Add(new Truck(registrationNumber, loadCapacity));
    }
    
    public void CreateConsumption(string registrationNumber, int numberOfKilometersDriven, int litersOfFuel)
    {
        var car = Cars.FirstOrDefault(c => c.GetRegistrationNumber() == registrationNumber);
        if (car is null)
        {
            return;
        }
        car.CreateConsumption(numberOfKilometersDriven, litersOfFuel);
    }
}