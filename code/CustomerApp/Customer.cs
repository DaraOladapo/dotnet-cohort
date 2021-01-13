using System;

namespace CustomerApp
{
    public class Customer: IDiscount, IOperation
    {
        //public int CustomerType { get; set; }
        public virtual double GetDiscount(double totalSaleValue)
        {
            return totalSaleValue;
        }
        private ILogger logger;
        public Customer(ILogger _logger)
        {
            logger = _logger;
        }
        public virtual void Add()
        {
            try
            {
                Console.WriteLine("Addition operation in progress");
            }
            catch (MyException ex)
            {
                logger.Handle(ex.Message);
            }
        }
    }
}
