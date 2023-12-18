using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class MockStarBucks : IMakeCoffee
    { 
        public bool CheckIngredientAvailabilty()
        {
            return true; 
        }

        public string CoffeeMaking(int SugarPerSpoon,int Coffeepack)
        {
            throw new NotImplementedException();
        }

    }
    public class StubStarBucks : IMakeCoffee
    {  
        public bool CheckIngredientAvailabilty()
        {
            return true;
        }
        public string CoffeeMaking(int SugarPerSpoon, int Coffeepack)
        {
            return "Your Order is Received";
        }

    }
    public class FakeStarBucks : IMakeCoffee
    {
        public bool CheckIngredientAvailabilty()
        {
            return true ;
        }

        public string CoffeeMaking(int SugarPerSpoon, int Coffeepack)
        {
            return "Your Order is Received";
        }

    }
}
