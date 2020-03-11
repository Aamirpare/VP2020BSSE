using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
namespace ClassesAndProperties.Threads
{
    public class ThreadDemo
    {
        public void Print()
        {
            Console.WriteLine("A thread is created and launched.");
            //Console.ReadKey();
        }
        public void CreateAndRunSimpleThread()
        {
            //You can create threds using different C# coding ways
            //The simplest way
            /*
                Thread th = new Thread(Print);
                th.Start();
            */

            //Also like this 
            /*
                ThreadStart ts = Print;
                Thread th = new Thread(ts);
                th.Start();
            */

            //Even like this 
            /*
                Thread th = new Thread(() => 
                {
                    Console.WriteLine("Thread is created");
                });
                th.Start();
            */
            //Or even like this as well
            Thread th = new Thread(delegate ()
            { 
               Console.WriteLine("Thread is created");
            });
        }
        public void CreatingAndRunMultipleThreads()
        {
            //Delegate is assigned Print Method reference
            ThreadStart ts = Print;
            //Thread array is created and each thread is given the same task to execute
            Thread[] threads = new Thread[]
            {
                new Thread(ts),
                new Thread(ts),
                new Thread(ts),
                new Thread(ts),
                new Thread(ts),
            };

            //All threads are started using loop 
            foreach (var t in threads)
            {
                t.Start();
            }
        }
    }
    public static class ExecuteDemo
    {
        public static void Print(object content)
        {
            Thread.Sleep(6000); 
            Console.WriteLine(content);
            //Console.ReadKey();
        }

        public static async void DisplayStudents()
        {
            Console.WriteLine("Thread using task library");
            await Task.CompletedTask;
        }

        public static void RunDemo()
        {
            //ThreadDemo threadDemo = new ThreadDemo();
            //threadDemo.CreateAndRunSimpleThread();
            //threadDemo.CreatingAndRunMultipleThreads();

            ParameterizedThreadStart pts = Print;
            //Parameterized thread
            Thread th1 = new Thread(pts);
            th1.Start("This is a parameterized thread function");

            Thread th2 = new Thread((content) => 
            {
                Thread.Sleep(6000);
                Console.WriteLine(content);
            });

            
            th2.Start("This is a message");

            DisplayStudents();
            
            var threadCount = Process.GetCurrentProcess().Threads.Count;
            Console.WriteLine("Total Threads in this process: " + threadCount);
            Console.ReadKey();
        }
    }
}
