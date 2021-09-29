using System;

namespace EX7_2 {
    class A { }
    class B : A { }
    class C {
        public static void Main() {
            A a = new A();
            B b = new B();
            A c = new B();
            B d = new A();
        }
    }
}
