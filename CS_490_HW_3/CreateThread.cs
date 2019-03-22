using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_490_HW_3
{
    class CreateThread
    {
        Node myNode;
        public CreateThread()
        {

        }

        public void run(MinHeap heap)
        {
            try
            {
                if (!heap.isHeaping())
                {
                    myNode = new Node();
                    heap.monitorInsert(myNode);
                }  
            }
            catch
            {
                // cleanup
            }
        }
    }
}
