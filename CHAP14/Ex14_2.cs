using System;
using static System.Console;



namespace Ex14_2
{
    class MainApp {
        static void Main(string[] args) {
            int[] array = { 11, 22, 33, 44, 55 };

            foreach (int a in array) {
                Action<int> action = (x) =>
                {
                    WriteLine(x * x);
                };
                action(a);
            }
        }
    }
}
