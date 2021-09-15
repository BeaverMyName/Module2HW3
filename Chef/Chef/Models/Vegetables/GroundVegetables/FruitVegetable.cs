using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.GroundVegetables
{
    public abstract class FruitVegetable : GroundVegetable
    {
        public FruitVegetable()
        {
            VegetableType = VegetableType.Generative;
            GrowingDuration = GrowingDuration.OneYear;
            IsHasSeeds = true;
        }
    }
}
