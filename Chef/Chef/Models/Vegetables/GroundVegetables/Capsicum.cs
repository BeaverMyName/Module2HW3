using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.GroundVegetables
{
    public class Capsicum : FruitVegetable
    {
        public override object Clone()
        {
            return new Capsicum() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
