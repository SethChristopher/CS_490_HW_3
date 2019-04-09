using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS_490_HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap ourHeap = new MinHeap(11);
            CreateThread creator = new CreateThread(3, 20, 3000, 1);
            ConsumeThread consumer1 = new ConsumeThread();
            consumer1.setId(1);
            ConsumeThread consumer2 = new ConsumeThread();
            consumer2.setId(2);
            heapWatcher watchman = new heapWatcher(1000, ourHeap);

            void create()
            {
                creator.run(ourHeap);
            }
            void consume1()
            {
                consumer1.run(ourHeap);
            }
            void consume2()
            {
                consumer2.run(ourHeap);
            }
            void watcher()
            {
                watchman.run();
            }

            Thread creatorThread = new Thread(new ThreadStart(create));
            Thread consume1Thread = new Thread(new ThreadStart(consume1));
            Thread consume2Thread = new Thread(new ThreadStart(consume2));
            Thread watchThread = new Thread(new ThreadStart(watcher));

            creatorThread.Start();
            consume1Thread.Start();
            consume2Thread.Start();

            try
            {
                creatorThread.Join();
            }
            catch(ThreadInterruptedException ex)
            {
            }
            Console.WriteLine("The producer's completed its tasks");

            watchThread.Start();

            try
            {
                watchThread.Join();
            }
            catch(ThreadInterruptedException ex)
            {
            }

            consumer1.stop(true);
            consumer2.stop(true);

            try
            {
                consume1Thread.Join();
                consume2Thread.Join();
            }
            catch(ThreadInterruptedException ex)
            {
            }

            Console.WriteLine("program is done.");
        }
    }
}
