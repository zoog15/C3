using System;
using static System.Console;


namespace TryCatch
{
    class MainApp {
        static void Main(string[] args) {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e) {
                WriteLine($"예외가 발생했습니다 : {e.Message}");
            }

            WriteLine("종료");
        }
    }
}
