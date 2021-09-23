using System;
using static System.Console;

namespace C3_Practice
{
    class RectArea
    {
        static void Main(string[] args) {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            // 문자열로 입력된 width와 height를 int형으로 변환
            int w = int.Parse(width);
            int h = int.Parse(height);

            // 높이 계산
            int area = w * h;

            Console.WriteLine($"사각형의 넓이는 : {area}");
        }
    }
}
