using System;
using MyExtension2;

namespace MyExtension2
{
    public static class IntegerExtension
    {
        public static String Append(this String mystring, String s) {
            return mystring + s;
        }
    }
}

namespace ExtensionMethod {
    class MainApp {
        static void Main(string[] args) {
            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));
        }
    }
}
