using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingBL
{
    public class MemberShipProcess:IOrderProcess
    {
        public int ProcessOrder()
        {
            // Activate member ship
            return 2;
        }
    }
}