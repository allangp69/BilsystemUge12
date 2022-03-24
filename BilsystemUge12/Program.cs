// See https://aka.ms/new-console-template for more information

using BilsystemUge12;

var system = new CarSystem();
system.CreateTruck("XX34567", 10000);
system.CreateConsumption("XX34567", 100, 70);
system.CreateConsumption("XX34567", 200, 150);

system.CreateTruck("XY34567", 10000);
system.CreateConsumption("XY34567", 100, 60);
system.CreateConsumption("XY34567", 200, 130);

system.CreateTruck("XY45678", 9000);
system.CreateConsumption("XY45678", 100, 50);
system.CreateConsumption("XY45678", 200, 110);

system.CreateTruck("XO56789", 11000);
system.CreateConsumption("XO56789", 100, 90);
system.CreateConsumption("XO56789", 200, 200);

system.CreateTruck("XY12345", 17000);
system.CreateConsumption("XY12345", 100, 100);
system.CreateConsumption("XY12345", 200, 210);

system.CreateTruck("XY23456", 21000);
system.CreateConsumption("XY23456", 100, 120);
system.CreateConsumption("XY23456", 200, 250);

system.CreatePassengerCar("YY56789", 4);
system.CreateConsumption("YY56789", 100, 7);
system.CreateConsumption("YY56789", 200, 15);

system.CreatePassengerCar("YO45678", 5);
system.CreateConsumption("YO45678", 100, 14);
system.CreateConsumption("YO45678", 200, 27);

system.CreatePassengerCar("YL34567", 3);
system.CreateConsumption("YL34567", 100, 5);
system.CreateConsumption("YL34567", 200, 11);

system.CreatePassengerCar("YF23456", 2);
system.CreateConsumption("YF23456", 100, 6);
system.CreateConsumption("YF23456", 200, 13);

system.CreatePassengerCar("YU12345", 4);
system.CreateConsumption("YU12345", 100, 8);
system.CreateConsumption("YU12345", 200, 20);

Console.WriteLine($"Total load capacity for trucks: {system.CalculateTotalLoadCapacity()} kg");
Console.WriteLine($"Most economic car: {system.FindMostEconimicCar()}");

Console.ReadKey();