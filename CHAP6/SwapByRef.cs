﻿using System;


namespace C3_Practice
{
    class SwapByRef
    {
        public static void Swap(ref int a,ref int b) {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args) {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(ref x,ref y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
