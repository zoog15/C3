using System;


namespace C3_Practice
{
    class SwapByValue
    {
        public static void Swap(int a, int b) {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args) {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(x, y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
