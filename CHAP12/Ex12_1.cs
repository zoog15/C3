using System;
using static System.Console;


namespace Ex12_1
{
    class MainApp {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
                arr[i] = i;

            try
            {
                for (int i = 0; i < 11; i++)
                    WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException e) {
                WriteLine("Out of Range");
            }
        }
    }
}
