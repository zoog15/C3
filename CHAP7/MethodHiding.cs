using System;


namespace C3_Practice
{
    class Base {
        public void MyMethod() {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base {
        public new void MyMethod() {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class MethodHiding {
        static void Main(string[] args) {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }
}
