using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_490_HW_3
{
    class CreateThread
    {
        int nodeCount;
        int feedCount;
        int priorityVal;
        int processSleeptime;
        int myId;

        public CreateThread( int feedCount, int priorityVal, int processSleeptime, int myId)
        {

            this.feedCount = feedCount;
            this.priorityVal = priorityVal;
            this.processSleeptime = processSleeptime;
            this.myId = myId;
        }

        public void run(MinHeap heap)
        {
            int n;
            this.nodeCount = heap.getMaxSize(); ;
            Random myRand = new Random();

            Console.WriteLine("Producer starting...");

            for (int feeding = 0; feeding < feedCount; feeding++)
            {
                try
                {
                    Console.WriteLine("Producer Adding Nodes...");
                    for(n = 0; n < nodeCount; n++)
                    {
                        //if (!heap.isFull())
                        //{
                            Node x = new Node();
                            heap.insert(x);
                        //}

                    }
                    Console.WriteLine("Producer things there are " + heap.getSize() + " nodes in minHeap");
                    if(feeding < feedCount)
                    {
                        Thread.Sleep(processSleeptime);
                    }
                }
                catch(ThreadInterruptedException ex)
                {
                }
            }
        }
    }
}
