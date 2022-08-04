using UsedCarLotLab;


//List of Cars
List<Car> Inventory = new List<Car>()
    {
    new Car("Audi", "A8", 2022, 70000.90m),
    new Car("Tesla", "Model s", 2021, 65000.00m),
    new Car("Honda", "Civic", 2020, 40000.99m),
    new Car("Toyota", "Highlander", 2019, 35000.79m),
    new UsedCar("Ford", "Explorer", 2018, 32000.99m, 25342),
    new UsedCar("Lincoln", "Navigator", 2017, 67000.01m, 45896),
    };

//Instantiate/create new object of CarLot
CarLot cars = new CarLot(Inventory);

//List Inventory
cars.ListCars();
Console.WriteLine($"{Inventory.Count + 1}. Sell a car");
Console.WriteLine($"{Inventory.Count + 2}. Quit");


