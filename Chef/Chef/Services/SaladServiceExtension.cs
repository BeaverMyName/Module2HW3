using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models.Vegetables;

namespace Chef.Services
{
    public static class SaladServiceExtension
    {
        public static Vegetable[] FindSpecificVegetables(this SaladService saladService, Type type)
        {
            var specificVegetables = new Vegetable[0];
            var step = 0;
            var vegetables = saladService.GetVegetables();

            for (var i = 0; i < vegetables.Length; i++)
            {
                if (vegetables[i].GetType() == type)
                {
                    var temp = specificVegetables;
                    specificVegetables = new Vegetable[++step];
                    for (var j = 0; j < temp.Length; j++)
                    {
                        specificVegetables[j] = temp[j];
                    }

                    specificVegetables[step - 1] = vegetables[i];
                }
            }

            if (specificVegetables == null)
            {
                return null;
            }
            else
            {
                return specificVegetables;
            }
        }
    }
}
