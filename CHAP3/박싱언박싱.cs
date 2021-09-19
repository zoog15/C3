using System;

namespace C3_Practice
{
    class BoxingUnboxing
    {
        static void Main(string[] args) {
            int a = 123;
            // a에 담긴 값을 박싱해서 힙에 저장
            object b = (object)a;
            // b에 담긴 값을 언박싱해서 스택에 저장
            int c = (int)b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.1414213;
            // x에 담긴 값을 박싱해서 힙에 저장
            object y = x;
            // y에 담긴 값을 언박싱해서 스택에 저장
            double z = (double)y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
