using System;


namespace C3_Practice
{
    class While
    {
        static void Main(string[] args) {
            int i = 10;

            while (i > 0) {
                Console.WriteLine($"i : {i--}");
            }
        }
    }
}
