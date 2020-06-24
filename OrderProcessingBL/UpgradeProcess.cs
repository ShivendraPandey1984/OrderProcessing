using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingBL
{
    public class UpgradeProcess:IOrderProcess
    {
        public int ProcessOrder()
        {
            return 3;
        }
    }
}