using System;

namespace CustomerApp
{
    public class GuestCustomer : IDiscount
    {
        public void Add()
        {
            throw new Exception("this operation is not allowed");
        }

        public double GetDiscount(double totalSaleValue)
        {
            return totalSaleValue - 15;
        }
    }
}
