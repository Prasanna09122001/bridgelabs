using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarBucksStore
    {
        public IMakeCoffee coffee;
        public StarBucksStore(IMakeCoffee coffee)
        {
            this.coffee = coffee;
        }
        public string OrderACoffee(int SugarPerSpoon,int CoffeePack)
        {
            if (coffee.CheckIngredientAvailabilty()) 
            {
                return coffee.CoffeeMaking(SugarPerSpoon, CoffeePack);
            }
            else
            {
                return "Sorry! COffee is not Available.";
            }
        }
    }
}
