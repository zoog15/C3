using System;
using static System.Console;

namespace C3_Practice
{
    class IncDecOperator
    {
        static void Main(string[] args) {
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
    }
}
