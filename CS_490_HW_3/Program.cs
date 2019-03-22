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
            CreateThread myCreation = new CreateThread();
            ConsumeThread myConsumption = new ConsumeThread();
            ConsumeThread myConsumption1 = new ConsumeThread();

            Thread Create = new Thread(() => myCreation.run(myHeap));
            Create.Start();
            Thread Consume = new Thread(() => myConsumption.run(myHeap));
            Consume.Start();
        }
    }
}
