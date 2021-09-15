﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models.Vegetables.UndergroundVegetables
{
    public class Onion : BulbVegetable
    {
        public Onion()
        {
            GrowingDuration = GrowingDuration.TwoYear;
        }

        public OnionType OnionType { get; init; }

        public override object Clone()
        {
            return new Onion() { Name = Name, Calories = Calories, Weight = Weight, OnionType = OnionType };
        }
    }
}
