using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.GroundVegetables
{
    public class Cabbage : LeaveVegetable
    {
        public CabbageType CabbageType { get; init; }

        public override object Clone()
        {
            return new Cabbage() { Name = Name, Calories = Calories, Weight = Weight, CabbageType = CabbageType };
        }
    }
}
