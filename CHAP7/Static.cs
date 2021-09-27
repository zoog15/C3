using System;


namespace C3_Practice
{
    class Global {
        public static int Count = 0;
    }

    class ClassA {
        public ClassA() {
            Global.Count++;
        }
    }

    class ClassB {
        public ClassB() {
            Global.Count++;
        }
    }

    class Static {
        static void Main() {
            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}
