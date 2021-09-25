using System;


namespace C3_Practice
{
    class Ex6_1
    {
        static double Square(double arg) {
            // return arg * arg;
            return Math.Pow(arg,2);
        }

        static void Main(string[] args) {
            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
