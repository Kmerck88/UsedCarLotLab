using System;
namespace UsedCarLotLab
{
    public class UsedCar : Car
    {
            //Here is the constructor you should use for the UsedCar class
        public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price) 
        {

            Mileage = mileage;
        }
        public double Mileage { get; set; }

        public override string ToString()
        {
            return $"{Make, -10} {Model, -12} {Year, -6} ${Price, 8} {Mileage, 6} miles (Used)"; //format ex: $"{make, -10}
        }
    }
}

