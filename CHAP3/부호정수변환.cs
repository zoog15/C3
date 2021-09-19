using System;

namespace C3_Practice
{
    class SignedUnsignedConversion
    {
        static void Main(string[] args) {
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a;
            Console.WriteLine(b);

            int x = -30;
            Console.WriteLine(x);

            // 언더플로우 발생
            uint y = (uint)x;
            Console.WriteLine(y);
        }
    }
}
