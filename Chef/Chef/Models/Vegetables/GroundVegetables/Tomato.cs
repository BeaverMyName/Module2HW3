using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.GroundVegetables
{
    public class Tomato : FruitVegetable
    {
        public override object Clone()
        {
            return new Tomato() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
