using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS_490_HW_3
{
    public class Node
    {
        Random myRand = new Random();
        public int processID;
        public int Priority;
        public int timeSlice;
       
        public Node()
        {
            processID = myRand.Next(50000);
            Priority = myRand.Next(21);
            timeSlice = myRand.Next(5000);
        }

        public void Execute()
        {
            Thread.Sleep(timeSlice);
            Console.WriteLine("Process ID: " + this.processID + " Priority: "
                + this.Priority + " Time: " + DateTime.Now);
        }
    }
}
