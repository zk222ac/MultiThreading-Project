using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContextSwitching
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(DoSomethingforThread1);
            Thread thread2 = new Thread(DoSomethingforThread2);
            thread1.Name = "thread1...........................";
            Console.WriteLine(thread1.Name);
            // worker thread has many but main thread is only one
            thread1.Start();
            thread2.Start();
            // Main Thread start here 
            Thread.CurrentThread.Name = "Main Thread................";
            Console.WriteLine(Thread.CurrentThread.Name);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Main Thread:" + i);
            }

            Console.ReadKey();

        }

        private static void DoSomethingforThread1()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Worker Thread 1:" + i);
            }
        }
        private static void DoSomethingforThread2()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Worker Thread 2:" + i);
            }
        }
    }
}
