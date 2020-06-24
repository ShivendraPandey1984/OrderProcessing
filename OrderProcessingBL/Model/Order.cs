using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingBL.Enums;
namespace OrderProcessingBL.Model
{
    public class Order
    {
        public Product ProductItem  // property
        { get; set; }
        public PaymentTypes PaymentTypeIs
        {
            get;set;
        }
    }
}
