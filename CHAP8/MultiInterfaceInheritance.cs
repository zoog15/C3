﻿using System;


namespace MultiInterfaceheritance
{
    interface IRunnable {
        void Run();
    }

    interface IFlyable {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable {
        public void Run() {
            Console.WriteLine("Run! Run!");
        }

        public void Fly() {
            Console.WriteLine("Fly! Fly!");
        }
    }

    class MainApp {
        static void Main(String[] args) {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
