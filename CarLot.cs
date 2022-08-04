using System;
namespace UsedCarLotLab
{
    public class CarLot
    {
        public CarLot(List<Car> vehicleLot)
        {
            VehicleLot = vehicleLot;
        }

        public List<Car> VehicleLot {get; set;}

    //Method to display list
    public void ListCars()
        {
            VehicleLot.ForEach(car => Console.WriteLine($"{VehicleLot.IndexOf(car) + 1}. {car.ToString()}"));
        }

    //Method to add a car to the inventory
    public void BuyCar(Car car)
        {
            VehicleLot.Add(car);
        }
    //Method to remove car
    public void SellCar(int index)
        {
            VehicleLot.RemoveAt(index);
        }
    }
}

