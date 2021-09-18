using System;

namespace C3_Practice
{
    class 정수형식
    {
        static void Main(string[] args) {
            sbyte a = -10;
            // 범위에 맞지않게 사용시 컴파일이 안됨
            // sbyte a_1 = -5000_0000_0000; // 0이 11개
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            // 큰 정수 리터럴을 타이핑할때 구분자(_)를 이용해 표시하면 보기 좋음
            int e = -1000_0000; // 0이 7개
            int f = 3_0000_0000; // 0이 8개

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000; // 0이 11개
            ulong h = 200_0000_0000_0000_0000; // 0이 18개

            Console.WriteLine($"g={g}, h={h}");
        }
    }
}
