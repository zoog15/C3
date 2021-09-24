using System;
using System.Collections;
using static System.Console;


namespace C3_Practice
{
    class ShiftOperator
    {
        static void Main(string[] args) {
            Console.WriteLine("Testing <<... ");

            // 1바이트로 나타낼 수 있는 수는 256가지, 따라서 8자리의 16진수면 int형식이 표현하는 모든 수 나타낼 수 있음
            int a = 1;
            Console.WriteLine("a      : {0:D5} (0x{0:X8})", a);
            Console.WriteLine("a << 1 : {0:D5} (Ox{0:X8})", a << 1);
            Console.WriteLine("a << 2 : {0:D5} (Ox{0:X8})", a << 2);
            Console.WriteLine("a << 5 : {0:D5} (Ox{0:X8})", a << 5);

            Console.WriteLine("\nTesting >>... ");

            int b = 255;
            Console.WriteLine("b      : {0:D5} (0x{0:X8})", b);
            Console.WriteLine("b >> 1 : {0:D5} (Ox{0:X8})", b >> 1);
            Console.WriteLine("b >> 2 : {0:D5} (Ox{0:X8})", b >> 2);
            Console.WriteLine("b >> 5 : {0:D5} (Ox{0:X8})", b >> 5);

            Console.WriteLine("\nTesting >> 2... ");

            int c = -255;
            Console.WriteLine("c      : {0:D5} (0x{0:X8})", c);
            Console.WriteLine("c >> 1 : {0:D5} (Ox{0:X8})", c >> 1);
            Console.WriteLine("c >> 2 : {0:D5} (Ox{0:X8})", c >> 2);
            Console.WriteLine("c >> 5 : {0:D5} (Ox{0:X8})", c >> 5);


        }
    }
}
