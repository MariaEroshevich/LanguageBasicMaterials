using Decorator;

Car car = new Lada("Car Lada");
Console.WriteLine(car.GetPrice());
Console.WriteLine(car.GetDescription());
car = new AutomaticParkingSystem(car, "Automatic parking system", 40.00m);

Console.WriteLine(car.GetPrice());
Console.WriteLine(car.GetDescription());
