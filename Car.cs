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
            return $"{Make,-10} {Model,-12} {Year,-6} ${Price,8}";
        }
    
        }

    }

