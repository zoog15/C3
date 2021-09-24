using System;


namespace C3_Practice
{
    class Foreach
    {
        static void Main(string[] args) {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (int a in arr) {
                Console.WriteLine(a);
            }
        }
    }
}
