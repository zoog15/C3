using System;
using static System.Console;




namespace EmitTest
{
    class MyClass {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod() {
            WriteLine("I'm old");
        }

        public void NewMethod() {
            WriteLine("I'm new");
        }
    }

    class MainApp {
        static void Main(string[] args) {
            MyClass obj = new MyClass();

            obj.OldMethod();
            obj.NewMethod();
        }
    }
}
