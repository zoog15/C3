using System;

namespace C3_Practice
{
    class Overflow
    {
        static void Main(string[] args) {
            uint a = uint.MaxValue; // uint의 최댓값: 4294967295

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}
