using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class InvoiceSerice
    {
        private readonly int costperkm = 10;
        private readonly int minimumFareNormal = 5;
        private readonly int costpermintuenormal = 1;
        private readonly int costperkmpremium = 15;
        private readonly int minimumFarePremium = 20;
        private readonly int costperminutepremium = 2;
        string Normal = "normal";
        public int totalnumofRides = 0;
        public double totalfare = 0;
        public double averagefare = 0;
        public int TotalnumofRides()
        {
            return totalnumofRides;
        }
        public double Totalfare()
        {
            return totalfare;
        }
        public double AverageFare()
        {
            return averagefare;
        }
        public double CalculateFareNormalpremium(string rideType, double distance, double time)
        {
            if (rideType.Equals(Normal))
            {
                double TotalAmount = distance * costperkm + time * costpermintuenormal;
                if (TotalAmount > minimumFareNormal)
                {
                    return TotalAmount;
                }
                return minimumFareNormal;
            }
            else
            {
                double TotalAmount = distance * costperkmpremium + time * costperminutepremium;
                if (TotalAmount > minimumFarePremium)
                {
                    return TotalAmount;
                }
                return minimumFarePremium;
            }
        }
        public double CalculateFare(Ride[] rides)
        {
            totalfare = 0;
            foreach(var ride in rides)
            {
                totalfare += CalculateFareNormalpremium(ride.type, ride.Distance, ride.time);
            }
            totalnumofRides = rides.Length;
            averagefare = totalfare / totalnumofRides;
            return totalfare;
        }
    }
}
