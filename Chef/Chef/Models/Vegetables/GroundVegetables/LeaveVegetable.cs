using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.GroundVegetables
{
    public abstract class LeaveVegetable : GroundVegetable
    {
        public LeaveVegetable()
        {
            VegetableType = VegetableType.Vegetative;
            GrowingDuration = GrowingDuration.TwoYear;
            StarchSpecification = StarchSpecification.Green;
        }
    }
}
