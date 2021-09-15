using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.UndergroundVegetables
{
    public class Carrot : RootVegetable
    {
        public Carrot()
        {
            GrowingDuration = GrowingDuration.OneYear;
        }

        public CarrotType CarrotType { get; init; }

        public override object Clone()
        {
            return new Carrot() { Name = Name, Calories = Calories, Weight = Weight, CarrotType = CarrotType };
        }
    }
}
