using System;

namespace PositionalPattern
{
    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            switch (client) {
                case ("학생", int n) when n < 18:
                    return 0.2;
                case ("학생", _):
                    return 0.1;
                case ("일반", int n) when n < 18:
                    return 0.1;
                case ("일반", _):
                    return 0.05;
                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave = (job: "일반", age: 21);
            var kim = (job: "직장인", age: 20);

            Console.WriteLine($"alice : {GetDiscountRate(alice)}");
            Console.WriteLine($"bob : {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie : {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave : {GetDiscountRate(dave)}");
            Console.WriteLine($"kim : {GetDiscountRate(kim)}");
        }
    }
}
