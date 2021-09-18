using System;

namespace C3_Practice
{
    class SignedUnsigned
    {
        static void Main(string[] args) {
            byte a = 255; // byte형식 255는 1111 1111
            sbyte b = (sbyte)a; // 캐스팅

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
