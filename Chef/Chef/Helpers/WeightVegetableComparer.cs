using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models.Vegetables;

namespace Chef.Helpers
{
    public class WeightVegetableComparer : IComparer<Vegetable>
    {
        public int Compare(Vegetable vegetable1, Vegetable vegetable2)
        {
            if (vegetable1.Weight > vegetable2.Weight)
            {
                return 1;
            }
            else if (vegetable1.Weight < vegetable2.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
