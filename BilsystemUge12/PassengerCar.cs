namespace BilsystemUge12;

public class PassengerCar
    : Car
{
    private readonly int numberOfSeats;

    public PassengerCar(string registrationNumber, int numberOfSeats)
        :base(registrationNumber)
    {
        this.numberOfSeats = numberOfSeats;
    }
}