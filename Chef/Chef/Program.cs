using System;
using Chef.Models.Vegetables;
using Chef.Models.Vegetables.GroundVegetables;

namespace Chef
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var starter = new Starter();
            starter.Run();
        }
    }
}
