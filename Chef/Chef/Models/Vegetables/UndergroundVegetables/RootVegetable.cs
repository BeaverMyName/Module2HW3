using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.UndergroundVegetables
{
    public abstract class RootVegetable : UndergroundVegetable
    {
        public RootVegetable()
        {
            StarchSpecification = StarchSpecification.Starchy;
        }
    }
}
