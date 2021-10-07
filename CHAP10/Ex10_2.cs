using System;
using System.Collections;
using static System.Console;


namespace Ex10_2
{
    class MainApp {
        static void Main(string[] args) {
            int[,] A = { { 3, 2 }, { 1, 4 } };
            int[,] B = { { 9, 2 }, { 1, 7 } };

            int a = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0];
            int b = A[0, 0] * B[0, 1] + A[0, 1] * B[0, 1];
            int c = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];
            int d = A[1, 0] * B[0, 1] + A[1, 1] * B[0, 1];

            int[,] result = { { a, b }, { c, d } };

            foreach (int arr in result)
                WriteLine(arr);
        }
    }
}
