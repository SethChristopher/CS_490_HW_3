using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_490_HW_3
{
    class heapWatcher
    {
        MinHeap myHeap;
        int idle;
        public heapWatcher(int idle, MinHeap myHeap)
        {
            this.myHeap = myHeap;
            this.idle = idle;
        }
        public void run()
        {
            Console.WriteLine("Who watches the Heapwatcher...,? who knows but heapWatcher started so bugger off you gonna cry? piss your pants maybe? maybe shit and cum??");
            while (myHeap.getSize() > 0)
            {
                try
                {
                    Thread.Sleep(1000);
                }
                catch (ThreadInterruptedException ex)
                {
                }
            }
            Console.WriteLine("HeapWatcher is exciting...!(?)");
        }
    }
}
