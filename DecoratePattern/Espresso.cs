using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    /// <summary>
    /// 濃縮
    /// </summary>
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
