using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Task_parallel_Library
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var source = new CancellationTokenSource();
            try
            {
                var t1 = Task.Factory.StartNew(() => DoImportantWork(1, 2000, source.Token));
                source.Cancel();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetType());
            }

            //var t1 = Task.Factory.StartNew(() => DoImportantWork(1, 1500));

            //var t2 = Task.Factory.StartNew(() => DoImportantWork(2, 3000));

            //var t3 = Task.Factory.StartNew(() => DoImportantWork(3, 1000));

            //var taklist = new list<task> { t1, t2, t3 };

            //task.waitall(taklist.toarray());

            var intList = new List<int>() { 1, 2, 3, 4, 4, 2, 2, 1, 3, 3, 4, 4, 4 };
            Parallel.ForEach(intList, (i) => Console.WriteLine(i));

            //var t6=Task.Factory.StartNew(()=>DoImportantWork(1, 1000)).ContinueWith((prevTask)=>DoOtherWork(1,3000));

            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Doing some other work");
            //    Thread.Sleep(250);
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static void DoImportantWork(int id,int sleepTime,CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("task {0} is beginning",id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} has completed",id);
        }
        static void DoOtherWork(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is beginning more work", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} has completed more work", id);
        }
    }
}
