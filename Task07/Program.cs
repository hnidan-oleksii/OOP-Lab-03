// Speed Racing

int carsNumber = int.Parse(Console.ReadLine());
Car[] cars = new Car[carsNumber];

for (int i = 0; i < carsNumber; i++)
{
    string[] values = Console.ReadLine().Split();

    string currModel = values[0];
    double currFuelAmount = double.Parse(values[1]);
    double currFuelConsumption = double.Parse(values[2]);

    cars[i] = new Car(currModel, currFuelAmount, currFuelConsumption);
}

string[] command = Console.ReadLine().Split();
while (command.Length != 1)
{
    string model = command[1];
    int distance = int.Parse(command[2]);

    Car currModelCar = cars.FirstOrDefault(car => string.Equals(car.Model, model));

    if (currModelCar.FuelConsumption * distance <= currModelCar.FuelAmount)
    {
        currModelCar.Travel(distance);
    }
    else
    {
        Console.WriteLine("Insufficient fuel for the drive");
    }

    command = Console.ReadLine().Split();
}

foreach (Car car in cars)
{
    Console.WriteLine(car);
}
