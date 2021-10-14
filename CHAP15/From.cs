﻿using System;
using static System.Console;
using System.Linq;



namespace From
{
    class MainApp {
        static void Main(string[] args) {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 8, 1, 10 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach (int n in result)
                WriteLine($"짝수 : {n}");
        }
    }
}
