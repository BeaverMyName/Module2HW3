using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.GroundVegetables
{
    public class Cauliflower : FlowerVegetable
    {
        public override object Clone()
        {
            return new Cauliflower() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
