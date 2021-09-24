using System;
using System.Collections;
using static System.Console;


namespace C3_Practice
{
    class NullConditionalOperator
    {
        static void Main(string[] args) {
            ArrayList a = null;
            a?.Add("야구"); // a?.가 null을 반환하므로 Add() 메소드 호출 안됨
            a?.Add("축구");
            // a?.가 null을 반환하므로 "Count:"외에는 아무것도 출력되지 않음
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList(); // a는 이제 어디상 null이 아님
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
        }
    }
}
