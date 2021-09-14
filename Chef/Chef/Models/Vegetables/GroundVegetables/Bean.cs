using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.GroundVegetables
{
    public class Bean : SeedVegetable
    {
        public override object Clone()
        {
            return new Bean() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
