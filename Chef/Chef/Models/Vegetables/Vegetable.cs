using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables
{
    public abstract class Vegetable : ICloneable
    {
        public string Name { get; init; }
        public int Calories { get; init; }
        public double Weight { get; init; }

        public abstract object Clone();
    }
}