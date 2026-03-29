using System;

class Driver
{
    public string Name { get; set; }
    public double Skill { get; set; }

    public Driver(string name, double skill)
    {
        Name = name;
        Skill = skill;
    }
}

class Car
{
    public string Model { get; set; }
    public double Speed { get; set; }
    public Driver Driver { get; set; }

    public Car(string model, double speed)
    {
        Model = model;
        Speed = speed;
    }

    public double CalculateSpeed()
    {
        if (Driver == null)
            return 0;
        return Speed * Driver.Skill;
    }
}

class Program
{
    static void RaceCars(Car car1, Car car2)
    {
        double car1Speed = car1.CalculateSpeed();
        double car2Speed = car2.CalculateSpeed();

        if (car1Speed > car2Speed)
            Console.WriteLine($"Car {car1.Model} with driver {car1.Driver.Name} was faster!");
        else if (car2Speed > car1Speed)
            Console.WriteLine($"Car {car2.Model} with driver {car2.Driver.Name} was faster!");
        else
            Console.WriteLine("It's a tie!");
    }

    static void Main()
    {

        Driver[] drivers = {
            new Driver("Bob", 1.2),
            new Driver("Greg", 1.1),
            new Driver("Jill", 1.3),
            new Driver("Anne", 1.0)
        };

        Car[] cars = {
            new Car("Hyundai", 120),
            new Car("Mazda", 130),
            new Car("Ferrari", 200),
            new Car("Porsche", 190)
        };

        Console.WriteLine("Choose a car no.1:");
        for (int i = 0; i < cars.Length; i++)
            Console.WriteLine($"{i + 1}. {cars[i].Model}");
        int car1Choice = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("Choose driver for car no.1:");
        for (int i = 0; i < drivers.Length; i++)
            Console.WriteLine($"{i + 1}. {drivers[i].Name}");
        int driver1Choice = Convert.ToInt32(Console.ReadLine()) - 1;

        cars[car1Choice].Driver = drivers[driver1Choice];

        Console.WriteLine("Choose a car no.2:");
        for (int i = 0; i < cars.Length; i++)
            Console.WriteLine($"{i + 1}. {cars[i].Model}");
        int car2Choice = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("Choose driver for car no.2:");
        for (int i = 0; i < drivers.Length; i++)
            Console.WriteLine($"{i + 1}. {drivers[i].Name}");
        int driver2Choice = Convert.ToInt32(Console.ReadLine()) - 1;

        cars[car2Choice].Driver = drivers[driver2Choice];

        RaceCars(cars[car1Choice], cars[car2Choice]);
    }
}