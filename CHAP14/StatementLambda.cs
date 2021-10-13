using System;
using static System.Console;


namespace SimpleLambda
{
    class MainApp {
        delegate string Concatenate(string[] args);

        static void Main(string[] args) {
            
            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                        result += s;

                    return result;
                };
            WriteLine(concat(args));
        }
    }
}
