using System;

namespace C3_Practice
{
    class IntegralConversion
    {
        static void Main(string[] args) {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            // sbyte의 최대값 127보다 1 큰수
            int x = 128;
            Console.WriteLine(x);
            
            // 오버플로우 발생
            sbyte y = (sbyte)x;
            Console.WriteLine(y);
        }
    }
}
