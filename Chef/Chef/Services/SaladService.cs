using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Services.ServiceInterfaces;
using Chef.Providers;
using Chef.Models.Vegetables;
using Chef.Helpers;
using Chef.Models;

namespace Chef.Services
{
    public class SaladService : ISaladService
    {
        private readonly WeightVegetableComparer _weightVegetableComparer;
        private readonly CaloriesVegetableComparer _caloriesVegetableComparer;
        private Salad _salad;
        private Vegetable[] _vegetables;

        public SaladService()
        {
            _weightVegetableComparer = new WeightVegetableComparer();
            _caloriesVegetableComparer = new CaloriesVegetableComparer();
            _vegetables = new Vegetable[0];
        }

        public int Calories
        {
            get
            {
                var calories = 0;
                foreach (var vegetable in _vegetables)
                {
                    calories += vegetable.Calories;
                }

                return calories;
            }
        }

        public double Weight
        {
            get
            {
                var weight = 0D;
                foreach (var vegetable in _vegetables)
                {
                    weight += vegetable.Weight;
                }

                return weight;
            }
        }

        public Salad MakeSalad(string name, Vegetable[] vegetables)
        {
            if (!string.IsNullOrEmpty(name) && vegetables.Length > 1)
            {
                _salad = new Salad() { Name = name, Vegetables = vegetables };
                _vegetables = _salad.Vegetables;
                return _salad;
            }

            return null;
        }

        public void SortVegetablesByWeight()
        {
            Array.Sort(_vegetables, _weightVegetableComparer);
        }

        public void SortVegetablesByCalories()
        {
            Array.Sort(_vegetables, _caloriesVegetableComparer);
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
