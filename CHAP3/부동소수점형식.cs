﻿using System;

namespace C3_Practice
{
    class FloatingPoint
    {
        static void Main(string[] args) {
            // float 형식 변수에 값을 직접 할당하려면 숫자 뒤에 f를 붙여줘야함
            float a = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(a);

            double b = 3.1415_9265_3589_3846;
            Console.WriteLine(b);
        }
    }
}
