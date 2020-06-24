using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingBL
{
    public class UpgradeProcess:IOrderProcess
    {
        public int ProcessOrder()
        { 
            // Apply upgrade 
            return 3;
        }
    }
}