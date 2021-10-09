using System;
using static System.Console;


namespace KillingProgram
{
    class MainApp {
        static void Main(string[] args) {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < 5; i++) {
                WriteLine(arr[i]);
            }

            WriteLine("종료");
        }
    }
}
