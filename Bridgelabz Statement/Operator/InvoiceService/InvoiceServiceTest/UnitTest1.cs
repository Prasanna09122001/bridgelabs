using ConsoleApp5;

namespace InvoiceServiceTest
{
    public class Tests
    {
        InvoiceSerice invoiceservice = new InvoiceSerice();
        [Test]
        public void GivenDistanceAndTimeWhenCheckedReturnFareValue()
        {
            double actual = invoiceservice.CalculateFareNormalpremium("normal",10, 5);
            double expected = 105;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenRidesWhenCheckedReturnFareValue()
        {
            Ride[] ride =
            {
                new Ride(){type="normal", Distance=10,time=5},
            };
            double actual = invoiceservice.CalculateFare(ride);
            double expected = 105;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenRidesWhenCheckedReturnNoofRide()
        {
            Ride[] ride =
            {
                new Ride(){type="normal",Distance=10,time=5},
                new Ride(){type="normal",Distance=20,time=15}
            };
            invoiceservice.CalculateFare(ride);
            double actual = invoiceservice.TotalnumofRides();
            double expected = ride.Length;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenRidesWithUserIdWhenCheckedReturnNoofRide()
        {
            string userid = "Prasanna";
            Ride[] ride =
            {
                new Ride(){type="premium",Distance=10,time=5},
                new Ride(){type="normal",Distance =10,time=5},
            };
            RideRepository rideRepository = new RideRepository();
            rideRepository.AddRides(userid, ride);
            double actual = invoiceservice.CalculateFare(rideRepository.GetRides(userid));
            double expected = 265;
            Assert.AreEqual(actual, expected);
        }
    }
}