namespace CustomerApp
{
    public class ChildCustomer : Customer
    {
        public override double GetDiscount(double totalSaleValue)
        {
            return totalSaleValue - 75;
        }
    }
}
