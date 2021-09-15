using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.UndergroundVegetables
{
    public class Potato : TuberVegetable
    {
        public PotatoType PotatoType { get; init; }

        public override object Clone()
        {
            return new Potato() { Name = Name, Calories = Calories, Weight = Weight, PotatoType = PotatoType };
        }
    }
}
