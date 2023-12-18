using CoffeeMaker;
using Moq;

namespace CoffeeMakerTest
{
    public class Tests
    {    [Test]
        public void OrderFakeCoffee()
        {
            StarBucksStore store = new StarBucksStore(new FakeStarBucks());
            string order = store.OrderACoffee(0, 4);
            Assert.AreEqual("Your Order is Received",order);
        }
        [Test]
        public void OrderStubCoffee()
        {
            StarBucksStore store = new StarBucksStore(new StubStarBucks());
            string order = store.OrderACoffee(2, 4);
            Assert.AreEqual("Your Order is Received", order);
        }
        [Test]
        public void OrderMockCoffee()
        {
            var service = new Mock<IMakeCoffee>();
            service.Setup(x => x.CheckIngredientAvailabilty()).Returns(true);
            service.Setup(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>())).
                Returns("Your Order is Received");
            StarBucksStore store = new StarBucksStore(service.Object);
            string order = store.OrderACoffee(2, 4);
            Assert.AreEqual("Your Order is Received", order);
        }
    }
}