using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.GroundVegetables
{
    public class Peas : SeedVegetable
    {
        public override object Clone()
        {
            return new Peas() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
