using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models.Vegetables;

namespace Chef.Common
{
    public class RandomVegetables
    {
        public Vegetable[] GetRandomVegetables(int maxSize, Vegetable[] vegetables)
        {
            if (maxSize < 2 || vegetables == null || vegetables.Length < 2)
            {
                return null;
            }
            else
            {
                var random = new Random();
                var randomVegetables = new Vegetable[maxSize];
                for (var i = 0; i < maxSize; i++)
                {
                    randomVegetables[i] = vegetables[random.Next(vegetables.Length)];
                }

                return randomVegetables;
            }
        }
    }
}
