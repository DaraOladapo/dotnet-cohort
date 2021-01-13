using System;

namespace Currency.Library
{
    public class Currency
    {
        public static decimal ConvertToGBP(decimal usdValue)
        {
            return usdValue * 0.74M;
        }  
        public static decimal ConvertToUSD(decimal gbpValue)
        {
            return gbpValue * 1.36M;
        }
    }
}
