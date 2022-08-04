using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLotLab
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public decimal Price { get; set; }
        public Car()
        {
            Make = string.Empty;
            Model = string.Empty;
            Year = 0;
            Price = 0;
        }
        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        public override string ToString()
        {
<<<<<<< HEAD
            return $"{Make} {Model} {Year} {Price}";
        }
        
=======
            return $"Make: {Make} Model: {Model} Year: {Year} Price: {Price}"; //format ex: $"{make, -10}
        }
>>>>>>> 299dbfcab92a7a6b5bd4659a61022fbd5d166441
    }

}
