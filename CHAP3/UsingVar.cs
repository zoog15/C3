using System;

namespace C3_Practice
{
    class UsingVar
    {

        static void Main(string[] args) {
            // var로 선언하는 변수는 반드시 초기화
            var a = 20;

            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);
        }
    }
}
