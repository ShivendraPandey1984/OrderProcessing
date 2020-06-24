using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingBL
{
    public class PhysicalProdcutProcess:IOrderProcess
    {
        public int ProcessOrder()
        {
            // Genrate a packing slip for shipping 
            // Generate a commision payment to agent 
            return 0;
        }
    }
}