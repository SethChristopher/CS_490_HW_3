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
            MinHeap myHeap = new MinHeap(5);
            CreateThread create = new CreateThread();
            ConsumeThread consume = new ConsumeThread();
            Thread createThread= new Thread(() => {
                if (!myHeap.heaping == false)
                {

                }

            });

            Thread consumeThread = new Thread(() =>
            {                
                while (!myHeap.isEmpty())
                {
                    consume.run(myHeap);
                }

            });


            createThread.Start();
            consumeThread.Start();




            createThread.Join();
            consumeThread.Join();


        }
    }
}
