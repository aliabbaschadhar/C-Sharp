using System;
using System.Threading;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multithreading = multiple threads of execution
            // useful when you have to run multiple tasks at the same time
            // Current task is running on the main thread
            // using System.Threading;

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            // Console.WriteLine($"Current Thread: {mainThread.Name}");

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);

            thread1.Start(); // Used to invoke the thread
            thread2.Start();

            // CountDown();
            // CountUp();

            // But if we want the main thread to wait for the other threads to finish then complete its execution then we will use it like this

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Main Thread finished"); // Will print before the others thread finished

        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer #1 :{i} seconds ");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 finished");
        }

        public static void CountUp()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Timer #2 :{i} seconds ");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 finished");
        }
    }
}