using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chef.Models.Vegetables;

namespace Chef.Models
{
    public class Salad
    {
        public string Name { get; init; }
        public Vegetable[] Vegetables { get; init; }
    }
}
