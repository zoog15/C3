﻿using System;

namespace PositionalPattern {
    class MainApp {
        private static double GetDiscountRate(object client) {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2, // 학생 & 18세 미만
                ("학생", _) => 0.1, // 학생 & 18세 이상
                ("일반", int n) when n < 18 => 0.1, // 일반 & 18세 미만
                ("일반", _) => 0.05, // 일반 & 18세 이상
                _ => 0
            };
        }

        static void Main(string[] args) {
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave = (job: "일반", age: 21);
            var kim = (job: "직장인", age: 20);

            Console.WriteLine($"alice : {GetDiscountRate(alice)}");
            Console.WriteLine($"bob : {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie : {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave : {GetDiscountRate(dave)}");
            Console.WriteLine($"kim : {GetDiscountRate(kim)}");
        }
    }
}
