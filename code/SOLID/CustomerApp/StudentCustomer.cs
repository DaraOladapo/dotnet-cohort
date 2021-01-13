namespace CustomerApp
{
    public class StudentCustomer : Customer
    {
        public override double GetDiscount(double totalSaleValue)
        {
            return totalSaleValue - 100;
        }
    }
}
