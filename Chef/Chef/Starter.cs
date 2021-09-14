using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Services;
using Chef.Providers;
using Chef.Common;
using Chef.Models.Vegetables.GroundVegetables;

namespace Chef
{
    public class Starter
    {
        private readonly SaladService _saladService;
        private readonly VegetableProvider _vegetableProvider;
        private readonly RandomVegetables _randomVegetables;

        public Starter()
        {
            _saladService = new SaladService();
            _vegetableProvider = new VegetableProvider();
            _randomVegetables = new RandomVegetables();
        }

        public void Run()
        {
            _saladService.MakeSalad("Random salad", _randomVegetables.GetRandomVegetables(100, _vegetableProvider.GetVegetables()));
            var calories = _saladService.Calories;
            _saladService.SortVegetablesByCalories();
            _saladService.SortVegetablesByWeight();
            var vegetables = _saladService.FindSpecificVegetables(typeof(Tomato));
        }
    }
}
