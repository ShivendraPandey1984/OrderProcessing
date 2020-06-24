using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingBL
{
   public interface IOrderFactory
    {
        IOrderProcess GetOrder(int paymentType);
    }
    public class OrderFactory: IOrderFactory
    {
        public IOrderProcess GetOrder(int paymentType)
        {
            switch (paymentType)
            {
                case 0:
                    return new PhysicalProdcutProcess();
                case 1:
                    return new BookProcess();
                case 2:
                    return new MemberShipProcess();
                case 3:
                    return new UpgradeProcess();
                case 4:
                    return new VideoProcess();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", paymentType));
            }
        }
    }
}

