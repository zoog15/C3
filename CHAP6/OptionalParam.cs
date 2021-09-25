﻿using System;


namespace C3_Practice
{
    class OptionalParam
    {
        static void PrintProfile(string name, string phone = "") {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args) {
            PrintProfile("중근");
            PrintProfile("관순", "010-123-1234");
            PrintProfile(name: "봉길");
            PrintProfile(name: "동주", phone: "010-789-7890");
        }
    }
}
