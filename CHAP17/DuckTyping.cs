using System;
using static System.Console;




namespace DuckTyping
{
    class Duck {
        public void Walk() {
            WriteLine(this.GetType() + ".Walk");
        }

        public void Swim()
        {
            WriteLine(this.GetType() + ".Swim");
        }

        public void Quack() {
            WriteLine(this.GetType() + ".Quack");
        }

        class Mallard : Duck { }

        class Robot {
            public void Walk()
            {
                WriteLine("Robot.Walk");
            }

            public void Swim()
            {
                WriteLine("Robot.Swim");
            }

            public void Quack()
            {
                WriteLine("Robot.Quack");
            }
        }

        class MainApp {
            static void Main(string[] args) {
                dynamic[] arr = new dynamic[] { new Duck(), new Mallard(), new Robot() };

                foreach (dynamic duck in arr) {
                    WriteLine(duck.GetType());
                    duck.Walk();
                    duck.Swim();
                    duck.Quack();

                    WriteLine();
                }
            }
        }
    }
}
