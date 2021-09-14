using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models.Vegetables;
using Chef.Providers.ProviderInterfaces;
using Chef.Models.Vegetables.GroundVegetables;
using Chef.Models.Vegetables.UndergroundVegetables;

namespace Chef.Providers
{
    public class VegetableProvider : IVegetableProvider
    {
        private readonly Vegetable[] _vegetables;

        public VegetableProvider()
        {
            _vegetables = new Vegetable[]
            {
                new Tomato() { Name = "Vine tomato", Calories = 102, Weight = 123 },
                new Tomato() { Name = "Cherry tomato", Calories = 51, Weight = 60 },
                new Capsicum() { Name = "Yellow capsicum", Calories = 120, Weight = 90 },
                new Spinach() { Name = "Baby spinach", Calories = 37, Weight = 75 },
                new Peas() { Name = "Snow peas", Calories = 446, Weight = 145 },
                new Cauliflower() { Name = "Broccoflower", Calories = 106, Weight = 134 },
                new Cabbage() { Name = "Green cabbage", Calories = 97, Weight = 90 },
                new Cabbage() { Name = "Red cabbage", Calories = 85, Weight = 75 },
                new Broccoli() { Name = "Chinese broccoli", Calories = 127, Weight = 91 },
                new Bean() { Name = "Butter beans", Calories = 194, Weight = 136 },
                new Bean() { Name = "Snake beans", Calories = 170, Weight = 110 },
                new Artichoke() { Name = "Globe artichoke", Calories = 122, Weight = 150 },
                new Beetroot() { Name = "Beetroot", Calories = 179, Weight = 136 },
                new Carrot() { Name = "Carrot", Calories = 200, Weight = 128 },
                new Garlic() { Name = "Garlic", Calories = 23, Weight = 5 },
                new Onion() { Name = "Red onion", Calories = 58, Weight = 45 },
                new Potato() { Name = "Potato", Calories = 470, Weight = 150 }
            };
        }

        public Vegetable[] GetVegetables()
        {
            var vegetables = new Vegetable[_vegetables.Length];

            for (var i = 0; i < _vegetables.Length; i++)
            {
                vegetables[i] = _vegetables[i].Clone() as Vegetable;
            }

            return vegetables;
        }
    }
}
