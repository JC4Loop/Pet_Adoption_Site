using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FWP___Pet_Adoption_Subsystem
{
    public class DepositExchangeRate
    {
        public static double ExchangeEurToGDP(double inputAmount)
        {
            double gdpResult = inputAmount * (1 * 0.847022);
            return Math.Round(gdpResult, 2);
        }

        public static double ExchangeRONToGDP(double inputAmount)
        {
            double gdpResult = inputAmount * (1 * 0.190798);
            return Math.Round(gdpResult, 2);
        }
    }
}