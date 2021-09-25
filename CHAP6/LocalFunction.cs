using System;


namespace C3_Practice
{
    class LocalFunction
    {
        static string ToLowerString(string input) {
            // 문자열을 배열로 만들어줌
            var arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = ToLowerChar(i); // 문자열의 각 항목에 대해 소문자로 바꿔줌
            }

            char ToLowerChar(int i) {  // 로컬 함수 선언
                if (arr[i] < 65 || arr[i] > 90) // A ~ Z가 아니라면 그대로 반환
                    return arr[i];
                else // A ~ Z 라면
                    return (char)(arr[i] + 32); // 32를 더하면 소문자로 바뀜
            }

            return new string(arr); // 배열을 다시 문자열로
        }

        static void Main(string[] args) {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#."));
        }
    }
}
