using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp
{
    interface IDiscount
    {
        double GetDiscount(double totalSales);
    }
}
