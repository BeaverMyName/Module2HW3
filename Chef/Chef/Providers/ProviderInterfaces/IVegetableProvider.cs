using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models.Vegetables;

namespace Chef.Providers.ProviderInterfaces
{
    public interface IVegetableProvider
    {
        public Vegetable[] GetVegetables();
    }
}
