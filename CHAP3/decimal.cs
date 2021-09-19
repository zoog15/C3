using System;

namespace C3_Practice
{
    class decimal형식
    {
        static void Main(string[] args) {
            // 숫자 뒤에 f를 붙이면 float형식 간주
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
            // 아무것도 없으면 double
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
            // m을 붙이면 decimal
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
