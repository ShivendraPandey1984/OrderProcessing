using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingBL
{
    public class VideoProcess:IOrderProcess
    {
        public int ProcessOrder()
        {
            // Add a free first add video to packing ship
            return 4;
        }
    }
}