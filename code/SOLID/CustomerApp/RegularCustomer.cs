namespace CustomerApp
{
    public class RegularCustomer : Customer, IRegularOperation
    {
        private double Balance { get; set; } = 15;
        public virtual double GetBalance()
        {
            return Balance;
        }

        public override double GetDiscount(double totalSaleValue)
        {
            return totalSaleValue - 50;
        }
    }
}
