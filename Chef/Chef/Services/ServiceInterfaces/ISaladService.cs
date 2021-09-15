using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models.Vegetables;
using Chef.Providers;
using Chef.Models;

namespace Chef.Services.ServiceInterfaces
{
    public interface ISaladService
    {
        public int Calories { get; }
        public double Weight { get; }

        public Salad MakeSalad(string name, Vegetable[] vegetables);
        public void SortVegetablesByWeight();
        public void SortVegetablesByCalories();
        public Vegetable[] GetVegetables();
    }
}
