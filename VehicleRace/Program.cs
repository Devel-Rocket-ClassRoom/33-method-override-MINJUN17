using System;

Vehicle[] vehicles = new Vehicle[3]
{
    new Car(),
    new Airplane(),
    new Boat()
};

Console.WriteLine("=== 경주 시작! ===");
foreach(Vehicle vehicle in vehicles)
{
    vehicle.Move();
}