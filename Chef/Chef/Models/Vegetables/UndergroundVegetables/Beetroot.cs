﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.UndergroundVegetables
{
    public class Beetroot : RootVegetable
    {
        public override object Clone()
        {
            return new Beetroot() { Name = Name, Calories = Calories, Weight = Weight };
        }
    }
}
