using System;


namespace C3_Practice
{
    class Employee {
        private string Name;
        private string Position;

        public void SetName(string Name) {
            this.Name = Name;
        }

        public string GetName() {
            return Name;
        }

        public void SetPosition(string Position) {
            this.Position = Position;
        }

        public string Getposition() {
            return this.Position;
        }
    }

    class This {
        static void Main(string[] args) {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.Getposition()}");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.Getposition()}");
        }
    }
}
