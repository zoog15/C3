using System;
using static System.Console;
using System.Linq;



namespace Ex15_2
{
    class Car { 
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    class MainApp {
        static void Main(string[] args) {
            Car[] cars = {
                new Car(){Cost= 56, MaxSpeed= 120 },
                new Car(){Cost= 70, MaxSpeed= 150 },
                new Car(){Cost= 45, MaxSpeed= 180 },
                new Car(){Cost= 32, MaxSpeed= 200 },
                new Car(){Cost= 82, MaxSpeed= 280 },
            };

            var seleted = from Car in cars
                          where Car.Cost < 60
                          orderby Car.Cost
                          select Car;

            foreach (Car car in seleted) {
                WriteLine($"{car.Cost}, {car.MaxSpeed}");
            }

        }
    }
}
