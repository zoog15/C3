﻿using System;


namespace C3_Practice
{
    class Break
    {
        static void Main(string[] args) {
            while (true) {
                Console.Write("계속할까요?(예/아니오) :");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    break;
            }
        }
    }
}
