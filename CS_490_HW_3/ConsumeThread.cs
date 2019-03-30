using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_490_HW_3
{
    class ConsumeThread
    {
        Node myNode;
        public void run(MinHeap heap)
        {
            try
            {
                // do work
                //            monitor.wait();
                if (!heap.heaping)
                {
                    myNode = heap.remove();
                    myNode.Execute();
                    //throw new InterruptedException("oh no consume is bad");
                }
                else
                {
                }
            }
            catch
            {
                // stop immediately and go home

            }
        }
    }
}
