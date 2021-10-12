using System;
using static System.Console;


namespace Ex13_1
{
    delegate int MyDelegate(int a, int b);

    class MainApp {
        static void Main(string[] args) {
            MyDelegate Callback;

            Callback = delegate (int a, int b) {
                return a + b;
            };
            WriteLine(Callback(3, 4));

            Callback = delegate (int a, int b)
            {
                return a - b;
            };
            WriteLine(Callback(7, 5));
        }
    }
}
