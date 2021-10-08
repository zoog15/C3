﻿using System;
using static System.Console;


namespace ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct {
        public T[] Array { get; set; }
        public StructArray(int size) {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class {
        public T[] Array { get; set; }
        public RefArray(int size) {
            Array = new T[size];
        }
    }
    class Base { }
    class Derived : Base { }

    class BaseArray<U> where U : Base { 
        public U[] Array { get; set; }
        public BaseArray(int size) {
            Array = new U[size];
        }
        public void CopyArray<T>(T[] Source) where T : U {
            Source.CopyTo(Array, 0);
        }
    }

    class MainApp {
        public static T CreateInstance<T>() where T : new() {
            return new T();
        }

        static void Main(string[] args) {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            for (int i = 0; i < 3; i++)
                WriteLine(a.Array[i]);

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            for (int i = 0; i < 3; i++)
                WriteLine(b.Array[i]);

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            for (int i = 0; i < 3; i++)
                WriteLine(c.Array[i]);

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();

            for (int i = 0; i < 3; i++)
                WriteLine(d.Array[i]);

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);

            for (int i = 0; i < 3; i++)
                WriteLine(e.Array[i]);
        }
    }
}
