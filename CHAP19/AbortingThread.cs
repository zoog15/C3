﻿using System;
using static System.Console;
using System.Threading;




namespace AbortingThread
{
    class SideTask {
        int count;

        public SideTask(int count) {
            this.count = count;
        }

        public void KeepAlive() {
            try
            {
                while (count > 0)
                {
                    WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                WriteLine("Count : 0");
            }
            catch (ThreadAbortException e)
            {
                WriteLine(e);
                Thread.ResetAbort();
            }
            finally {
                WriteLine("Clearing resource...");
            }
        }
    }

    class MainApp {
        static void Main(string[] args) {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            WriteLine("Starting thread...");
            t1.Start();
            Thread.Sleep(100);

            WriteLine("Aborting thread...");
            t1.Abort();

            WriteLine("Waiting until thread stops...");
            t1.Join();

            WriteLine("Finished");
        }
    }
}