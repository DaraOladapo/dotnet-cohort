namespace CustomerApp
{
    public class PrimeCustomer : RegularCustomer, IPrimeOperation
    {
        private double Balance { get; set; } = 25;
        public override double GetBalance()
        {
            return Balance;
        }

        public override double GetDiscount(double totalSaleValue)
        {
            return base.GetDiscount(totalSaleValue) - 100;
            //return totalSaleValue - 150;
        }
    }
}
