using System;
using static System.Console;
using System.Threading;




namespace BasicThread
{
    class MainApp {
        static void DoSomething() {
            for (int i = 0; i < 5; i++) {
                WriteLine($"DoSomething : {i}");
                // Sleep() 메서드를 만나면 인수(10) 만큼 CPU 사용을 멈춤. 이떄 단위는 밀리초
                Thread.Sleep(10);
            }
        }

        static void Main(string[] args) {
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            WriteLine("Starting thread...");
            t1.Start();

            for (int i = 0; i < 5; i++) {
                WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }

            WriteLine("Waiting until thread stops...");
            t1.Join();

            WriteLine("Finished");
        }
    }
}