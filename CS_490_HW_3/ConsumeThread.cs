using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_490_HW_3
{
    class ConsumeThread
    {
        int myId;
        Node myNode;
        public Boolean stopped;
        public void stop(Boolean value)
        {
            // may need a this.stopped
            stopped = value;
        }
        public void setId(int thisId)
        {
            myId = thisId;
        }
        public void run(MinHeap heap)
        {
            try
            {
                while (!stopped)
                {
                    // do work
                    //monitor.wait();
                    if (!heap.isEmpty())
                    {
                        myNode = heap.remove();
                        myNode.Execute();
                        Console.WriteLine("Thread " + myId + " has finished executing.");
                        //throw new InterruptedException("oh no consume is bad");
                    }
                    else
                    {
                        Console.WriteLine("Thread " + myId + " is sleeping.");
                        Thread.Sleep(3000);
                    }
                }

            }
            catch
            {
                // stop immediately and go home
            }
            Console.WriteLine("Thread " + myId + " exiting - completed");
        }
    }
}
