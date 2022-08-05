using UsedCarLotLab;
Console.WriteLine("Welcome to the Used Car Lot!\n");

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

//Program loop
bool runProgram = true;
while (runProgram)
{
    //List Inventory
    cars.ListCars();
    Console.WriteLine($"{Inventory.Count + 1}. Sell a car");
    Console.WriteLine($"{Inventory.Count + 2}. Quit");
    while (true)
    {
        //Get user input
        Console.Write("\nPlease enter an option to buy a car, sell a car, or quit: ");
        int userIput = int.Parse(Console.ReadLine());

        //If user chooses sell a car option
        if (userIput == Inventory.Count + 1)
        {
            Console.WriteLine("\nPlease enter the Make, Model, Year, Price, Milage separated by spaces. ");
            string[] sellerLot = Console.ReadLine().ToLower().Split(" ");

            string make = sellerLot[0];
            string model = sellerLot[1];
            int year = int.Parse(sellerLot[2]);
            decimal price = decimal.Parse(sellerLot[3]);
            double mileage = double.Parse(sellerLot[4]);

            Car car = new UsedCar(make, model, year, price, mileage);
            cars.BuyCar(car);
            cars.ListCars();
            
            break;

        }
        //If user chooses to quit
        else if (userIput == Inventory.Count + 2)
        {
            runProgram = false;
            break;
        }
        else
        {
            cars.SellCar(userIput);
            cars.ListCars();
            Console.WriteLine();
            break;
        }
        
     }
    runProgram = Validator.Validator.GetContinue();
}




