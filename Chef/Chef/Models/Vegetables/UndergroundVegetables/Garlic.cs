using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.UndergroundVegetables
{
    public class Garlic : BulbVegetable
    {
        public Garlic()
        {
            GrowingDuration = GrowingDuration.MultiYear;
        }

        public GarlicType GarlicType { get; init; }

        public override object Clone()
        {
            return new Garlic() { Name = Name, Calories = Calories, Weight = Weight, GarlicType = GarlicType };
        }
    }
}
