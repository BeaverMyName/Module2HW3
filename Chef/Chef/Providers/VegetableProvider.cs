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
                new Tomato() { Name = "Black Krim tomato", Calories = 102, Weight = 123, TomatoType = TomatoType.BlackKrim },
                new Tomato() { Name = "Cherry tomato", Calories = 51, Weight = 60, TomatoType = TomatoType.Cherry },
                new Capsicum() { Name = "Bell capsicum", Calories = 120, Weight = 90, CapsicumType = CapsicumType.Bell },
                new Spinach() { Name = "Baby spinach", Calories = 37, Weight = 75 },
                new Cauliflower() { Name = "Yellow cauliflower", Calories = 106, Weight = 134, CauliflowerType = CauliflowerType.Yellow },
                new Cabbage() { Name = "Green cabbage", Calories = 97, Weight = 90, CabbageType = CabbageType.Green },
                new Cabbage() { Name = "Red cabbage", Calories = 85, Weight = 75, CabbageType = CabbageType.Red },
                new Broccoli() { Name = "Broccoli", Calories = 127, Weight = 91 },
                new Artichoke() { Name = "Artichoke", Calories = 122, Weight = 150 },
                new Beetroot() { Name = "Beetroot", Calories = 179, Weight = 136, BeetrootType = BeetrootType.Classic },
                new Carrot() { Name = "Imperator carrot", Calories = 200, Weight = 128, CarrotType = CarrotType.Imperator },
                new Garlic() { Name = "Spring garlic", Calories = 23, Weight = 5, GarlicType = GarlicType.Spring },
                new Onion() { Name = "Red onion", Calories = 58, Weight = 45, OnionType = OnionType.RedWing },
                new Potato() { Name = "Dore potato", Calories = 470, Weight = 150, PotatoType = PotatoType.Dore }
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
