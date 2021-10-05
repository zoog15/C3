using System;


namespace Ex9_2
{
    class MainApp {
        static void Main(string[] args) {
            var nameCard = new { Name = "상현", Age = 26 };
            Console.WriteLine("이름:{0}, 나이:{1}", nameCard.Name, nameCard.Age);

            var complex = new { Real = 1, Imaginary = 0.01 };
            Console.WriteLine("Real:{0}, Imaginary : {1}", complex.Real, complex.Imaginary);
        }
    }
}
