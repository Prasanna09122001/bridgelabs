using System;
namespace ConsoleApp5
{
    class program
    {
        static void Main()
        {
            InvoiceSerice invoiceSerice = new InvoiceSerice();
            string userid = "Prasanna";
            Ride[] ride =
            {
                new Ride(){Distance=10,time=5},
                new Ride(){Distance=10,time=15},
            };
            RideRepository rideRepository = new RideRepository();
            rideRepository.AddRides(userid, ride);
            Console.WriteLine(invoiceSerice.CalculateFare(rideRepository.GetRides(userid)));
        }
    }
}
