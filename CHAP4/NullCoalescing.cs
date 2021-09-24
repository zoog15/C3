using System;
using System.Collections;
using static System.Console;


namespace C3_Practice
{
    class NullCoalescing
    {
        static void Main(string[] args) {
            int? num = null;
            Console.WriteLine($"{num ?? 0}");

            num = 99;
            Console.WriteLine($"{num ?? 0}");

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
        }
    }
}
