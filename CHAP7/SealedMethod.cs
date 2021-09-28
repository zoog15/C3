using System;


namespace C3_Practice
{
    class Base {
        public virtual void SealMe() { 
        }
    }

    class Derived : Base {
        public sealed override void SealMe(){
        }
    }

    class WantToOverride : Derived {
        public override void SealMe() { 
        }
    }

    class SealedMethod {
        static void Main(string[] args) { 
        
        }
    }
}
